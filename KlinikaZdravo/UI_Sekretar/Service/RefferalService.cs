// File:    RefferalService.cs
// Created: Tuesday, May 26, 2020 2:40:27 PM
// Purpose: Definition of Class RefferalService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.DoctorService
{
   public class RefferalService : IService<ReferralLetter, long>
    {

         private int duration;
        private readonly IRefferalLetterRepository Repository;
        public RefferalService(IRefferalLetterRepository repository)
        {
            Repository = repository;
        }


        private readonly IRefferalLetterRepository repository;

        private int Duration;
      
      public Refferal AddRefferalToHospitalTreatment(HospitalTreatment hospitalTreatment, String additionalInfo, Patient patient)

      {
         throw new NotImplementedException();
      }
      
      public ReferralLetter AddRefferalLatter(ReferralLetter refferalLatter)
      {
         throw new NotImplementedException();
      }

        public ReferralLetter Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReferralLetter> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReferralLetter Create(ReferralLetter entity) => Repository.Create(entity);

        public void Update(ReferralLetter entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ReferralLetter entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }
    }
}