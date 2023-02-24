// File:    PatientAccountController.cs
// Created: Tuesday, June 23, 2020 5:50:36 PM
// Purpose: Definition of Class PatientAccountController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.SecretaryService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class PatientAccountController : IController<Patient, long>
   {
        private static PatientAccountController Instance;
        public PatientAccountController PatientAccountControllerB;
        public PatientsAccountsService PatientsAccountsService;
        private readonly IService<Patient, long> Service;

        public PatientAccountController(IService<Patient, long> service)
        {
            Service = service;

        }

        public static PatientAccountController GetInstance(IService<Patient, long> service)
        {
            if (Instance == null)
            {
                Instance = new PatientAccountController(service);
            }
            return Instance;
        }

        public Patient ChangeTemporaryToPermanent(Patient patient)
      {
         throw new NotImplementedException();
      }

        public IEnumerable<Patient> GetAll() => Service.GetAll();

        public Patient GetByID(long id) => Service.Get(id);


        public Patient Create(Patient entity) => Service.Create(entity);


        public void Update(Patient entitiy) => Service.Update(entitiy);


        public void Delete(Patient entity) => Service.Delete(entity);
        
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