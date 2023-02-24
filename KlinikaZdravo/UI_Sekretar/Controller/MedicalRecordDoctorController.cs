// File:    MedicalRecordDoctorController.cs
// Created: Tuesday, June 23, 2020 5:50:40 PM
// Purpose: Definition of Class MedicalRecordDoctorController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.MedicalRecordService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class MedicalRecordDoctorController : IController<MedicalRecord, long>
   {
      private static MedicalRecordDoctorController Instance; 
        public MedicalRecordDoctorController MedicalRecordDoctorControllerB;
        public MedicalRecordExaminatinService MedicalRecordExaminatinService;
        public MedicalRecordService MedicalRecordService;

        private readonly IService<MedicalRecord, long> Service;

        public MedicalRecordDoctorController(IService<MedicalRecord, long> service)
        {
            Service = service;
        }
        public static MedicalRecordDoctorController GetInstance(IService<MedicalRecord, long> service)
        {
            if (Instance == null)
            {
                Instance = new MedicalRecordDoctorController(service);
            }
            return Instance;
        }

        public void AddAllergie(Allergie alergie)
      {
         throw new NotImplementedException();
      }
      
      public void AddVaccine(Vaccine vaccine)
      {
         throw new NotImplementedException();
      }
      
      public void AddCurrentTherapy(Therapy therapy)
      {
         throw new NotImplementedException();
      }
      
      public List<Examination> ShowMedicalHistories(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void AddToMedicalHistory(Examination examination)
      {
         throw new NotImplementedException();
      }
      
      public void AddPrescription(Prescription presciption)
      {
         throw new NotImplementedException();
      }
      
      public void AddExamination(Therapy therapy,Diagnosis diagmosis, Examination examination)
      {
         throw new NotImplementedException();
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
      
      public Prescription FindPrescription(Specialization specialist)
      {
         throw new NotImplementedException();
      }
      
      public Examination FindExamination(Doctor doctor)
      {
         throw new NotImplementedException();
      }

        public IEnumerable<MedicalRecord> GetAll()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetByID(long id) => Service.Get(id);

        public MedicalRecord Create(MedicalRecord entity) => Service.Create(entity);

        public void Update(MedicalRecord entitiy) => Service.Update(entitiy);

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