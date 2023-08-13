using Microsoft.EntityFrameworkCore;
using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.DataAccesses
{
    /// <summary>
    /// Defines a class named CalendarDataAccess that implements the ICalendarDataAccess interface.
    /// </summary>
    public class CalendarDataAccess : ICalendarDataAccess
    {
        private readonly MySQLConnection _context;

        /// <summary>
        /// Constructor that accepts an instance of MySQLConnection (DbContext) injected by dependency injection
        /// </summary>
        /// <param name="context">MySQL connection context</param>
        public CalendarDataAccess(MySQLConnection context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public Calendar StartNewProduction(int productIdToCreate, DateTime startDate, DateTime endDate)
        {
            var calendar = new Calendar()
            {
                ProductIdToCreate = productIdToCreate,
                StartDate = startDate,
                EndDate = endDate,
            };

            _context.Calendar.Add(calendar);
            _context.SaveChanges();

            return calendar;
        }

        /// <inheritdoc />
        public List<CalendarData> GetAllCalendarInformation()
        {
            var query =
                from c in _context.Calendar
                join p in _context.Product on c.ProductIdToCreate equals p.Id
                select new CalendarData
                {
                    ProductName = p.Name,
                    EndDate = c.EndDate,
                    StartDate = c.StartDate,
                };

            return query.ToList();
        }
    }
}
