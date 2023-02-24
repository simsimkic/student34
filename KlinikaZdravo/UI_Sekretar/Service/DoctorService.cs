// File:    DoctorService.cs
// Created: Thursday, May 28, 2020 2:21:57 PM
// Purpose: Definition of Class DoctorService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Medicine;
using ClassDiagram.Model.Questions;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.DoctorService
{
    public class DoctorService : IService<Doctor, long>
    {
        private readonly IDoctorAccountRepository Repository;

        public DoctorService(IDoctorAccountRepository repository)
        {
            Repository = repository;
        }

        public List<MedicalRecord> ShowAllMedicalRecords()
        {
         throw new NotImplementedException();
        }
      
      public List<Drug> ShowAllDrugs()
      {
         throw new NotImplementedException();
      }
      
      public Prescription AddPrescription(Prescription prescription, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalRecord> SearchMedicalRecord(String name)
      {
         throw new NotImplementedException();
      }
      
      public void ShowMedicalRecord(MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public bool IsNameValid(String name)
      {
         throw new NotImplementedException();
      }
      
      public Drug EditDrugInfo()
      {
         throw new NotImplementedException();
      }
      
      public Article AddArticle(Article article,Doctor doctor)
      {
         throw new NotImplementedException();
      }

        public Doctor Get(long id) => Repository.GetByID(id);
        public IEnumerable<Doctor> GetAll() => Repository.GetAll();
        public Doctor Create(Doctor doctor) => Repository.Create(doctor);
        public void Update(Doctor doctor) => Repository.Update(doctor);
        public void Delete(Doctor doctor) => Repository.Delete(doctor);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }
    }
}