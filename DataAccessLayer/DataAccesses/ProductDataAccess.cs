﻿using ProductionDataAccessLayer.Classes;
using ProductionDataAccessLayer.DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDataAccessLayer.DataAccesses
{
    /// <summary>
    /// Defines a class named ProductDataAccess that implements the IProcessDataAccess interface.
    /// </summary>
    public class ProductDataAccess : IProductDataAccess
    {
        private readonly MySQLConnection _context;

        /// <summary>
        /// Constructor that accepts an instance of MySQLConnection (DbContext) injected by dependency injection
        /// </summary>
        /// <param name="context">MySQL connection context</param>
        public ProductDataAccess(MySQLConnection context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public List<Product> GetAllProducts()
        {
            List<Product> result = _context.Product.ToList();
            return result;
        }


        /// <inheritdoc />
        public Product CreateProduct(string name)
        {
            var product = new Product()
            {
                Name = name
            };

            _context.Product.Add(product);
            _context.SaveChanges();

            return product;
        }
    }
}
