// File:    IDrugRepository.cs
// Created: Monday, June 22, 2020 7:52:47 PM
// Purpose: Definition of Interface IDrugRepository

using System;
using ClassDiagram.Model.Medicine;

namespace ClassDiagram.Repository.Abstract
{
   public interface IDrugRepository : IRepository<Drug,long>
   {
   }
}