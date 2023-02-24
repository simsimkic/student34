// File:    Survey.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Survey

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Questions
{
   public class Survey : IIdentifiable<long>
    {
        public long Id { get; set; }
        private String AdditionalComment { get; set; }
        private String Questions { get; set; }
        private Marks Marks;
        private String Subject { get; set; }

        public List<Patient> Pacijenti;

        public Survey() { }
        public Survey(long id) 
        {
            Id = id;
        }
        public Survey(long id, string additionalComment, string questions, string subject, List<Patient> pacijenti)
        {
            Id = id;
            AdditionalComment = additionalComment;
            Questions = questions;
            Subject = subject;
            Pacijenti = pacijenti;
        }

      public List<Patient> Patient
      {
         get
         {
            if (Pacijenti == null)
                    Pacijenti = new System.Collections.Generic.List<Patient>();
            return Pacijenti;
         }
         set
         {
            RemoveAllPatient();
            if (value != null)
            {
               foreach (ClassDiagram.Model.Users.Patient oPatient in value)
                  AddPatient(oPatient);
            }
         }
      }
  
      public void AddPatient(ClassDiagram.Model.Users.Patient newPatient)
      {
         if (newPatient == null)
            return;
         if (this.Pacijenti == null)
            this.Pacijenti = new System.Collections.Generic.List<Patient>();
         if (!this.Pacijenti.Contains(newPatient))
            this.Pacijenti.Add(newPatient);
      }
      

      public void RemovePatient(ClassDiagram.Model.Users.Patient oldPatient)
      {
         if (oldPatient == null)
            return;
         if (this.Pacijenti != null)
            if (this.Pacijenti.Contains(oldPatient))
               this.Pacijenti.Remove(oldPatient);
      }
      
      public void RemoveAllPatient()
      {
         if (Pacijenti != null)
                Pacijenti.Clear();
      }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}