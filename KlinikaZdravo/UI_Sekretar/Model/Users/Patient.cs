
// File:    Patient.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Patient



using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using KlinikaZdravo.Model.DoctorExaminations;

namespace ClassDiagram.Model.Users
{
   public class Patient : RegisteredUser
    {
        public long MedicalRecordId { get; set; }
        public List<DoctorExaminations.Examination> Examinations;

        public Patient() { }
        public Patient(long id)
        {

            Id = id;/*
            MedicalRecord = new MedicalRecord();
            Examinations = new List<Examination>();*/
        }
        public Patient(long id, long medicalRecordId, List<DoctorExaminations.Examination> examinations) : base(id)
        {
            MedicalRecordId = medicalRecordId;
            Examinations = examinations;
        }

        private void AddExamination(DoctorExaminations.Examination examination)
        {
            throw new NotImplementedException();
        }


        public void RemoveAllExamination()
        {
            if (Examinations != null)
                Examinations.Clear();
        }


    }
}