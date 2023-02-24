// File:    Diagnosis.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Diagnosis

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.DoctorExaminations
{
   public class Diagnosis : IIdentifiable<long>
    {
        public long Id { get; set; }
        private String Notes { get; set; }

        public Therapy[] Therapy;

        public Diagnosis()
        {
          
        }
        public Diagnosis(long id)
        {
            Id = id;
            Notes = "";
        }

        public Diagnosis(long id, String notes)
        {
            Id = id;
            Notes = notes;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}