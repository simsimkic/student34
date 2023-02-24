// File:    Contact.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Contact

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class Contact : IIdentifiable<long>
    {
        public long Id { get; set; }
        public String PhoneNumber { get; set; }
        public String EmailAdress { get; set; }

        public Contact() { }

        public Contact(long id) 
        {
            Id = id;
        }

        public Contact(long id, String phoneNumber, string emailAdress) 
        {
            Id = id;
            PhoneNumber = phoneNumber;
            EmailAdress = emailAdress;
        }
        public Contact(long id, String phoneNumber)
        {
            Id = id;
            PhoneNumber = phoneNumber;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}