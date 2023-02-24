// File:    Renovation.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Renovation

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Rooms
{
   public class Renovation : IIdentifiable<long>
    {
        public long Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

       // public Room Room { get; set; } 
       public long IdRoom { get; set; }//da bi znali u kojoj sobi je renoviranje

        public Renovation() { }
        public Renovation(long id)
        {
            Id = id;
        }
        public Renovation(long id,DateTime fromDate,DateTime toDate,long idRoom)
        {
            Id = id;
            FromDate = fromDate;
            ToDate = toDate;
            IdRoom =idRoom;

        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}