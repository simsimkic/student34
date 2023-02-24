// File:    Menager.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Menager

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
    public class Manager : RegisteredUser
    {
        public Manager() { }
        public Manager(long id):base(id) { }
    }
}