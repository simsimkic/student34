// File:    Adress.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Adress

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class Adress : IIdentifiable<long>
    {
        public long Id { get; set; }
        public String Street { get; set; }
        public String Number { get; set; }
        public City City { get; set; }

        public Adress() {
            Street = "";
        }


        public Adress(long id) 
        {
            Id = id;
        }

       public Adress(long id, string street, string number, City city) 

        {
            Street = street;
            Number = number;
            City = city;
        }
        public Adress(long id, string street, string number)
        {
            Id = id;
            Street = street;
            Number = number;
        }


        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}