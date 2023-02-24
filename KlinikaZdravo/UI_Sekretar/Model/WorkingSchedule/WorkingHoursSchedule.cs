// File:    WorkingHoursSchedule.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class WorkingHoursSchedule

using System;
using System.Collections.Generic;
using ClassDiagram.Repository.Abstract;
using iTextSharp.text;

namespace ClassDiagram.Model.WorkingSchedule
{
   public class WorkingHoursSchedule : IIdentifiable<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public List<WorkingDay>workingDays { get; set; }
        public WorkingHoursSchedule() { }
        public WorkingHoursSchedule(long id)
        {
            Id = id;
        }
        public WorkingHoursSchedule(long id,string name ,DateTime from, DateTime to/*,List<WorkingDay> workingDays*/)
        {
            Id = id;
            Name = name;

            From = from;
            To = to;
        }



        public System.Collections.Generic.List<WorkingDay> workingDay;
      
      /// <summary>
      /// Property for collection of WorkingDay
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<WorkingDay> WorkingDay
      {
         get
         {
            if (workingDay == null)
               workingDay = new System.Collections.Generic.List<WorkingDay>();
            return workingDay;
         }
         set
         {
            RemoveAllWorkingDay();
            if (value != null)
            {
               foreach (WorkingDay oWorkingDay in value)
                  AddWorkingDay(oWorkingDay);
            }
         }
      }
      
      /// <summary>
      /// Add a new WorkingDay in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddWorkingDay(WorkingDay newWorkingDay)
      {
         if (newWorkingDay == null)
            return;
         if (this.workingDay == null)
            this.workingDay = new System.Collections.Generic.List<WorkingDay>();
         if (!this.workingDay.Contains(newWorkingDay))
            this.workingDay.Add(newWorkingDay);
      }
      
      /// <summary>
      /// Remove an existing WorkingDay from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveWorkingDay(WorkingDay oldWorkingDay)
      {
         if (oldWorkingDay == null)
            return;
         if (this.workingDay != null)
            if (this.workingDay.Contains(oldWorkingDay))
               this.workingDay.Remove(oldWorkingDay);
      }
      
      /// <summary>
      /// Remove all instances of WorkingDay from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllWorkingDay()
      {
         if (workingDay != null)
            workingDay.Clear();
      }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}