// File:    VacationSchedule.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class VacationSchedule

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.WorkingSchedule
{
    public class VacationSchedule : IIdentifiable<long>
    {
        public long Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Name{get;set;}
        public VacationSchedule() { }
        public VacationSchedule(long id) 
        {
            Id = id;
        }
        public VacationSchedule(long id,DateTime from,DateTime to)
        {
            Id = id;
            From = from;
            To = to;
        }
        public VacationSchedule(long id, string name, DateTime from, DateTime to)
        {
            Id = id;
            Name = name;
            From = from;
            To = to;
        }



        public ClassDiagram.Model.Users.Secretary secretary;
      
      /// <summary>
      /// Property for ClassDiagram.Model.Users.Secretary
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public ClassDiagram.Model.Users.Secretary Secretary
      {
         get
         {
            return secretary;
         }
         set
         {
            if (this.secretary == null || !this.secretary.Equals(value))
            {
               if (this.secretary != null)
               {
                  ClassDiagram.Model.Users.Secretary oldSecretary = this.secretary;
                  this.secretary = null;
                  oldSecretary.RemoveVacationSchedule(this);
               }
               if (value != null)
               {
                  this.secretary = value;
                  this.secretary.AddVacationSchedule(this);
               }
            }
         }
      }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}