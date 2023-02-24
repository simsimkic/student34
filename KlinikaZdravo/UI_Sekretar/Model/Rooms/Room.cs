// File:    Room.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Room

using System;
using System.Collections.Generic;
using System.Windows.Controls;
using ClassDiagram.Repository.Abstract;
using iTextSharp.text;

namespace ClassDiagram.Model.Rooms
{
   public class Room : IIdentifiable<long>
    {
        public long Id { get; set; }
        
        public int Floor { get; set; }
        public RoomType Type;
        public List<Inventory> Inventory;
        public List<Renovation> Renovation;


        public Room() { }
        public Room(long id) 
        {
            Id = id;
        }
        public Room(long id,int floor,RoomType type) {
            Id = id;
            Floor = floor;
            Type = type;
        }
        public Room(long id, int floor, List<Inventory> inventory, List<Renovation> renovation)
        {
            Id = id;
            Floor = floor;
            Inventory = inventory;
            Renovation = renovation;
        }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}