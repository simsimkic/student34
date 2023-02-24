// File:    Employee.cs
// Created: Tuesday, May 26, 2020 2:43:23 PM
// Purpose: Definition of Class Employee

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
    public class Employee : RegisteredUser
    {
        public string Employment { get; set; }
        public Employee() { }
        public Employee(long id) : base(id) { }
        public Employee(long id, string name, string surname, DateTime dateOfBirth,
            string personalId/*,Contact contact*/, string employment)
            : base(id, name, surname, dateOfBirth, personalId/*,contact*/)
        {
            Employment = employment;
        }

    }
}