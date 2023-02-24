// File:    DoctorController.cs
// Created: Tuesday, June 23, 2020 6:08:18 PM
// Purpose: Definition of Class DoctorController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Medicine;
using ClassDiagram.Model.Questions;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.DoctorService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class DoctorController : IController<Doctor,long>
   {
        private static DoctorController Instance;
        public DoctorController DoctorControllerB;
        public DoctorService DoctorService;
        public RefferalService RefferalService;

        private readonly IService<Doctor, long> Service;

        public DoctorController(IService<Doctor, long> service)
        {
            Service = service;
        }

        public static DoctorController GetInstance(IService<Doctor, long> service)
        {
            if (Instance == null)
            {
                Instance = new DoctorController(service);
            }
            return Instance;
        }


        public Prescription AddPresciption(Prescription presciption, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalRecord> ShowAllMedicalRecords()
      {
         throw new NotImplementedException();
      }
      
      public List<Drug> ShowAllDrugs()
      {
         throw new NotImplementedException();
      }
      
      public Refferal AddRefferalToHospitalTreatment(HospitalTreatment hospitalTreatment, String additionalInfo, Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public ReferralLetter AddRefferalLatter(ReferralLetter refferalLetter)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalRecord> SearchMedicalRecord()
      {
         throw new NotImplementedException();
      }
      
      public MedicalRecord ShowMedicalRecord(String name)
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsNameValid(String name)
      {
         throw new NotImplementedException();
      }
      
      public Drug EditDrugInfo()
      {
         throw new NotImplementedException();
      }
      
      public Article AddArticle(Article article, Doctor doctor)
      {
         throw new NotImplementedException();
      }

        public IEnumerable<Doctor> GetAll() => Service.GetAll();

        public Doctor GetByID(long id) => Service.Get(id);

        public Doctor Create(Doctor doctor) => Service.Create(doctor);
        public void Update(Doctor doctor) => Service.Update(doctor);
        public void Delete(Doctor doctor) => Service.Delete(doctor);

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