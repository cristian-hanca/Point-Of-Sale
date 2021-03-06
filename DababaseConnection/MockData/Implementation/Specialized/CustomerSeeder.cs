﻿using System;
using System.Data.Entity.Migrations;
using System.Globalization;
using Models;
using RandomNameGenerator;

namespace DababaseConnection.MockData.Implementation.Specialized
{
    /// <summary>
    ///     Specialized Mock Data Seeder for Customers.
    /// </summary>
    internal class CustomerSeeder : BaseMockSeeder
    {
        private readonly Random _random;
        private readonly int _count;

        /// <summary>
        ///     Creates a new Customer Seeder that will generate the 75 Customers.
        /// </summary>
        public CustomerSeeder() : this(75)
        {
        }


        /// <summary>
        ///     Creates a new Customer Seeder that will generate the the given number of Customers.
        /// </summary>
        /// <param name="count">Number of Customers to generate.</param>
        public CustomerSeeder(int count)
        {
            if (count < 0)
                throw new ArgumentException("Count less than 0", nameof(count));
            _random = new Random();
            _count = count;
        }

        public new void SeedCustomers(DataContext context)
        {
            long cnp = 1111111111111;
            for (int i = 0; i < _count; i++)
            {
                context.Customers.AddOrUpdate(new Customer
                {
                    Cnp = cnp++.ToString(),
                    Name = FirstLetterToUpper(NameGenerator.GenerateFirstName(
                        _random.NextDouble() >= 0.5 ? Gender.Male : Gender.Female)),
                    LastName = FirstLetterToUpper(NameGenerator.GenerateLastName()),
                    Phone = "070012345678"
                });
            }
            context.SaveChanges();
        }

        private string FirstLetterToUpper(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }
}