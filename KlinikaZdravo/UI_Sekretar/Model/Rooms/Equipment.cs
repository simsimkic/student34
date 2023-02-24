// File:    Equipment.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Equipment

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Rooms
{
   public class Equipment : IIdentifiable<long>
   {
        public long Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }

        public Inventory inventory { get; set; }

        public Equipment() { }
        public Equipment(long id)
        {
            Id = id;
        }
        public Equipment(long id,string name,int quantity)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
        }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}