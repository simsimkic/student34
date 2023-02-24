// File:    MedicalRecordPatientController.cs
// Created: Tuesday, June 23, 2020 5:50:43 PM
// Purpose: Definition of Class MedicalRecordPatientController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.MedicalRecordService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class MedicalRecordPatientController : IController<MedicalRecord,long>
   {
        private static MedicalRecordPatientController Instance;
        public MedicalRecordPatientController MedicalRecordPatientControllerB;
        public MedicalRecordService MedicalRecordService;

        public MedicalRecordPatientController(IService<MedicalRecord, long> service)
        {
            //dicalRecordService = service;
        }
        public static MedicalRecordPatientController GetInstance(IService<MedicalRecord, long> service)
        {
            if (Instance == null)
            {
                Instance = new MedicalRecordPatientController(service);
            }
            return Instance;
        }

        public List<Allergie> ShowAllergies()
      {
         throw new NotImplementedException();
      }
      
      public List<Vaccine> ShowVaccines()
      {
         throw new NotImplementedException();
      }
      
      public Therapy ShowCurrentTherapy()
      {
         throw new NotImplementedException();
      }
      
      public List<Examination> ShowMedicalHistories(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Prescription FindPrescription(Specialization specialist)
      {
         throw new NotImplementedException();
      }
      
      public Examination FindExamination(Doctor doctor)
      {
         throw new NotImplementedException();
      }
      
      public void AddPrescription(Prescription prescription)
      {
         throw new NotImplementedException();
      }

        public IEnumerable<MedicalRecord> GetAll()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetByID(long id)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord Create(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }

        public void Update(MedicalRecord entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}