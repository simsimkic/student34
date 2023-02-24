// File:    IPatientAccountRepository.cs
// Created: Monday, June 22, 2020 5:45:11 PM
// Purpose: Definition of Interface IPatientAccountRepository

using System;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Abstract
{
   public interface IPatientAccountRepository : IRepository<Patient,long>
   {
   }
}