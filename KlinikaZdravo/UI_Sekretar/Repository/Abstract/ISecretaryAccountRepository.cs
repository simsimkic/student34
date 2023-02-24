// File:    ISecretaryAccountRepository.cs
// Created: Monday, June 22, 2020 5:45:12 PM
// Purpose: Definition of Interface ISecretaryAccountRepository

using System;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Abstract
{
   public interface ISecretaryAccountRepository : IRepository<Secretary,long>
   {
   }
}