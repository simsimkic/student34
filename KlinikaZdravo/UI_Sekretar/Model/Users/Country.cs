// File:    Country.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Country

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class Country : IIdentifiable<long>
    {
        public long Id { get; set; }
        public String Name { get; set; }

        public Country() { }

        public Country(long id) 
        {
            Id = id;
        }
        public Country(long id, string name)
        {
            Id = id;
            Name = name;
        }


        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}