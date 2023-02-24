// File:    User.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class User

using System;
using System.Runtime.InteropServices.ComTypes;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class User : IIdentifiable<long>
   {
        public long Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String PersonalId { get; set; }
        public Boolean IsTemporaryAccount { get; set; }

        public Adress Adress { get; set; }
        public Contact Contact { get; set; }

        public User() { }
        public User(long id) 
        {
            Id = id;
        }
        public User(long id, string name, string surname, DateTime dateOfBirth, string personalId, Boolean isTemporaryAccount, Adress address, Contact contact) 
        {
            Id = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            PersonalId = personalId;
            IsTemporaryAccount = isTemporaryAccount;
            Adress = address;
            Contact = contact;
        }
        public User(long id, string name, string surname, DateTime dateOfBirth, string personalId, Adress address, Contact contact)
        {
            Id = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            PersonalId = personalId;
            Adress = address;
            Contact = contact;
        }
        public User(long id, string name, string surname, DateTime dateOfBirth, string personalId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            PersonalId = personalId;
        }
        public User(long id,string name,string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public User(long id, string name, string surname, string personalId, bool isTemporrary, Contact contact)
        {
            Id = id;
            Name = name;
            Surname = surname;
            PersonalId = personalId;
            IsTemporaryAccount = isTemporrary;
            Contact = contact;
            Adress = new Adress();
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}