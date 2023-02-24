// File:    IManagerAccountRepository.cs
// Created: Monday, June 22, 2020 6:00:53 PM
// Purpose: Definition of Interface IManagerAccountRepository

using System;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Abstract
{
   public interface IManagerAccountRepository : IRepository<Manager,long>
   {
   }
}