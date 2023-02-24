// File:    IEagerCSVRepository.cs
// Created: Monday, June 22, 2020 8:46:52 PM
// Purpose: Definition of Interface IEagerCSVRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Repository.Csv
{
   public interface IEagerCSVRepository<T,ID> where T : IIdentifiable<ID>
    where ID : IComparable
   {
      T GetEager(ID id);
      
      IEnumerable<T> GetAllEager();
   
   }
}