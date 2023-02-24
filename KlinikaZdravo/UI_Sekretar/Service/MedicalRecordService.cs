// File:    MedicalRecordService.cs
// Created: Tuesday, May 26, 2020 2:40:23 PM
// Purpose: Definition of Class MedicalRecordService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.MedicalRecordService
{
   public class MedicalRecordService : IService<MedicalRecord, long>
    {
        private readonly IMedicalRecordRepository Repository;
        public MedicalRecordService(IMedicalRecordRepository repository)
        {
            Repository = repository;
        }
        public void ShowInformation(MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public void ShowCurrentTherapy(MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public void ShowMedicalHistories(MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public void AddPrescription(Prescription prescription, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Prescription FindPrescription(Specialization specialist, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Examination FindExamination(Doctor doctor, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }

        public MedicalRecord Get(long id) => Repository.GetByID(id);

        public IEnumerable<MedicalRecord> GetAll()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Create(MedicalRecord entity) => Repository.Create(entity);

        public void Update(MedicalRecord entity) => Repository.Update(entity);

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