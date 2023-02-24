// File:    Bed.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Bed

using System;
using System.Windows.Controls;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Rooms
{
   public class Bed : IIdentifiable<long>
    {
        public long Id { get; set; }
        private bool IsTaken { get; set; }
        private DateTime From { get; set; }
        private DateTime To { get; set; }

        public Bed() { }
        public Bed(long id)
        {
            Id = id;
        }
        public Bed(long id,bool isTaken,DateTime from,DateTime to)
        {
            Id = id;
            IsTaken = isTaken;
            From = from;
            To = to;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}