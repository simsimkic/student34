// File:    Secretary.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Secretary

using System;
using System.Collections.Generic;
using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class Secretary : Employee, IIdentifiable<long>
    {
        public List<VacationSchedule> VacationSchedules;

        public Secretary() { }
        public Secretary(long id) 
        {
            Id = id;
            VacationSchedule = new List<VacationSchedule>();

        }
        public Secretary(long id, List<VacationSchedule> vacationSchedules) : base(id)
        {
            VacationSchedules = vacationSchedules;
        }
      
      public List<VacationSchedule> VacationSchedule
      {
         get
         {
            if (VacationSchedules == null)
                VacationSchedules = new System.Collections.Generic.List<VacationSchedule>();
            return VacationSchedules;
         }
         set
         {
            RemoveAllVacationSchedule();
            if (value != null)
            {
               foreach (VacationSchedule oVacationSchedule in value)
                  AddVacationSchedule(oVacationSchedule);
            }
         }
      }
      
      /// <summary>
      /// Add a new VacationSchedule in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddVacationSchedule(VacationSchedule newVacationSchedule)
      {
         if (newVacationSchedule == null)
            return;
         if (this.VacationSchedules == null)
            this.VacationSchedules = new System.Collections.Generic.List<VacationSchedule>();
         if (!this.VacationSchedules.Contains(newVacationSchedule))
         {
            this.VacationSchedules.Add(newVacationSchedule);
            newVacationSchedule.Secretary = this;
         }
      }
      
      /// <summary>
      /// Remove an existing VacationSchedule from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveVacationSchedule(VacationSchedule oldVacationSchedule)
      {
         if (oldVacationSchedule == null)
            return;
         if (this.VacationSchedules != null)
            if (this.VacationSchedules.Contains(oldVacationSchedule))
            {
               this.VacationSchedules.Remove(oldVacationSchedule);
               oldVacationSchedule.Secretary = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of VacationSchedule from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllVacationSchedule()
      {
         if (VacationSchedules != null)
         {
            System.Collections.ArrayList tmpVacationSchedule = new System.Collections.ArrayList();
            foreach (VacationSchedule oldVacationSchedule in VacationSchedules)
               tmpVacationSchedule.Add(oldVacationSchedule);
                VacationSchedules.Clear();
            foreach (VacationSchedule oldVacationSchedule in tmpVacationSchedule)
               oldVacationSchedule.Secretary = null;
            tmpVacationSchedule.Clear();
         }
      }
      public System.Collections.Generic.List<PersonalDay> personalDay;
      
      /// <summary>
      /// Property for collection of PersonalDay
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<PersonalDay> PersonalDay
      {
         get
         {
            if (personalDay == null)
               personalDay = new System.Collections.Generic.List<PersonalDay>();
            return personalDay;
         }
         set
         {
            RemoveAllPersonalDay();
            if (value != null)
            {
               foreach (PersonalDay oPersonalDay in value)
                  AddPersonalDay(oPersonalDay);
            }
         }
      }
      
      /// <summary>
      /// Add a new PersonalDay in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPersonalDay(PersonalDay newPersonalDay)
      {
         if (newPersonalDay == null)
            return;
         if (this.personalDay == null)
            this.personalDay = new System.Collections.Generic.List<PersonalDay>();
         if (!this.personalDay.Contains(newPersonalDay))
            this.personalDay.Add(newPersonalDay);
      }
      
      /// <summary>
      /// Remove an existing PersonalDay from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePersonalDay(PersonalDay oldPersonalDay)
      {
         if (oldPersonalDay == null)
            return;
         if (this.personalDay != null)
            if (this.personalDay.Contains(oldPersonalDay))
               this.personalDay.Remove(oldPersonalDay);
      }
      
      /// <summary>
      /// Remove all instances of PersonalDay from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPersonalDay()
      {
         if (personalDay != null)
            personalDay.Clear();
      }
      public System.Collections.Generic.List<WorkingHoursSchedule> workingHoursSchedule;
      
      /// <summary>
      /// Property for collection of WorkingHoursSchedule
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<WorkingHoursSchedule> WorkingHoursSchedule
      {
         get
         {
            if (workingHoursSchedule == null)
               workingHoursSchedule = new System.Collections.Generic.List<WorkingHoursSchedule>();
            return workingHoursSchedule;
         }
         set
         {
            RemoveAllWorkingHoursSchedule();
            if (value != null)
            {
               foreach (WorkingHoursSchedule oWorkingHoursSchedule in value)
                  AddWorkingHoursSchedule(oWorkingHoursSchedule);
            }
         }
      }
      
      /// <summary>
      /// Add a new WorkingHoursSchedule in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddWorkingHoursSchedule(WorkingHoursSchedule newWorkingHoursSchedule)
      {
         if (newWorkingHoursSchedule == null)
            return;
         if (this.workingHoursSchedule == null)
            this.workingHoursSchedule = new System.Collections.Generic.List<WorkingHoursSchedule>();
         if (!this.workingHoursSchedule.Contains(newWorkingHoursSchedule))
            this.workingHoursSchedule.Add(newWorkingHoursSchedule);
      }
      
      /// <summary>
      /// Remove an existing WorkingHoursSchedule from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveWorkingHoursSchedule(WorkingHoursSchedule oldWorkingHoursSchedule)
      {
         if (oldWorkingHoursSchedule == null)
            return;
         if (this.workingHoursSchedule != null)
            if (this.workingHoursSchedule.Contains(oldWorkingHoursSchedule))
               this.workingHoursSchedule.Remove(oldWorkingHoursSchedule);
      }
      
      /// <summary>
      /// Remove all instances of WorkingHoursSchedule from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllWorkingHoursSchedule()
      {
         if (workingHoursSchedule != null)
            workingHoursSchedule.Clear();
      }
   
   }
}