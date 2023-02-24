// File:    IDoctorAccountRepository.cs
// Created: Monday, June 22, 2020 6:00:53 PM
// Purpose: Definition of Interface IDoctorAccountRepository

using System;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Abstract
{
   public interface IDoctorAccountRepository : IRepository<Doctor,long>
   {
   }
}