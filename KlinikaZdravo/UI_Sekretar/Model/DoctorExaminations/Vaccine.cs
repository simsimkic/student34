// File:    Vaccine.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Vaccine

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.DoctorExaminations
{
   public class Vaccine : IIdentifiable<long>
    {
        public long Id { get; set; }
        public DateTime DateOfReceiving { get; set; }
        public String VaccineName { get; set; }

        public Vaccine() { }
        public Vaccine(long id) {
            Id = id;
        }
        public Vaccine(long id, DateTime dateOfReceiving, String vaccineName)
        {
            Id = id;
            DateOfReceiving = dateOfReceiving;
            VaccineName = vaccineName;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}