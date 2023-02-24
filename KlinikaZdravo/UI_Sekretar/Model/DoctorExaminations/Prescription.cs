// File:    Prescription.cs
// Created: Sunday, May 24, 2020 12:33:50 PM
// Purpose: Definition of Class Prescription

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.DoctorExaminations
{
    public class Prescription : IIdentifiable<long>
    {
        public long Id { get; set; }
        public String Drug { get; set; }
        public String Use { get; set; }

        public Prescription()
        {

        }
        public Prescription(long id)
        {
            Id = id;
        }

        public Prescription(long id, String drug, String use)
        {
            Id = id;
            Drug = drug;
            Use = use;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}