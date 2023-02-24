// File:    Inventory.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Inventory

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Rooms
{
   public class Inventory : IIdentifiable<long>
    {
        public long Id { get; set; }
        private int Amount { get; set; }

        public Room Room { get; set; }
        public System.Collections.Generic.List<Bed> bed;

        public Inventory() { }
        public Inventory(long id) 
        {
            Id = id;
        }
        public Inventory(long id,int amount,Room room)
        {
            Id = id;
            Amount = amount;
            Room = room;
        }


        /// <summary>
        /// Property for collection of Bed
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Bed> Bed
      {
         get
         {
            if (bed == null)
               bed = new System.Collections.Generic.List<Bed>();
            return bed;
         }
         set
         {
            RemoveAllBed();
            if (value != null)
            {
               foreach (Bed oBed in value)
                  AddBed(oBed);
            }
         }
      }
      
      /// <summary>
      /// Add a new Bed in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddBed(Bed newBed)
      {
         if (newBed == null)
            return;
         if (this.bed == null)
            this.bed = new System.Collections.Generic.List<Bed>();
         if (!this.bed.Contains(newBed))
            this.bed.Add(newBed);
      }
      
      /// <summary>
      /// Remove an existing Bed from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveBed(Bed oldBed)
      {
         if (oldBed == null)
            return;
         if (this.bed != null)
            if (this.bed.Contains(oldBed))
               this.bed.Remove(oldBed);
      }
      
      /// <summary>
      /// Remove all instances of Bed from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllBed()
      {
         if (bed != null)
            bed.Clear();
      }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}