// File:    PatientsAccountsService.cs
// Created: Thursday, May 28, 2020 9:40:03 PM
// Purpose: Definition of Class PatientsAccountsService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.SecretaryService
{
   public class PatientsAccountsService : IService<Patient, long>
    {
        private readonly IPatientAccountRepository Repository;
        private PatientAccountRepository patientAccountRepository;

       public Patient ChangeTemporaryToPermanent(Patient patient)
      {
         throw new NotImplementedException();
      }

        public PatientsAccountsService(IPatientAccountRepository repository) 
        {
            Repository = repository;
        }

        public Patient Create(Patient entity) => Repository.Create(entity);

        public void Delete(Patient entity) => Repository.Delete(entity);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }
        public Patient Get(long id) => Repository.GetByID(id);

        public IEnumerable<Patient> GetAll() => Repository.GetAll();

        public void Update(Patient entity) => Repository.Update(entity);
    }
}