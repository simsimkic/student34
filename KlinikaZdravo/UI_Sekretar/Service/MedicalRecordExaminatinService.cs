// File:    MedicalRecordExaminatinService.cs
// Created: Tuesday, May 26, 2020 2:40:23 PM
// Purpose: Definition of Class MedicalRecordExaminatinService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.MedicalRecordService
{
   public class MedicalRecordExaminatinService : IService<MedicalRecord, long>
    {
        private readonly IMedicalRecordRepository repository;

        public void AddAllergie(Allergie alergie,MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public void AddVaccine(Vaccine vaccine, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public void AddCurrentTherapy(Therapy therapy, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public List<Examination> ShowMedicalHistories(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void AddToMedicalHistory(Examination examination, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public void AddPrescription(Prescription prescription, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public void AddExamination(Therapy therapy, Diagnosis diagnosis, Examination examination, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }

        public MedicalRecord Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MedicalRecord> GetAll()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Create(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }

        public void Update(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }
    }
}