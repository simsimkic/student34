// File:    City.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class City

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class City : IIdentifiable<long>
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String PostalCode { get; set; }
        public Country Country { get; set; }

        public City() {}

        public City(long id) 
        {
            Id = id;
        }
        public City(long id, string name)
        {
            Id = id;
            Name = name;
        }
        public City(long id, string name, string postalCode, Country country)
        {
            Id = id;
            Name = name;
            PostalCode = postalCode;
            Country = country;
        }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}