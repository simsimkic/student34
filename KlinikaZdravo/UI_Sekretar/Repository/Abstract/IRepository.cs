// File:    IRepository.cs
// Created: Monday, June 22, 2020 5:45:08 PM
// Purpose: Definition of Interface IRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Repository;

namespace ClassDiagram.Repository.Abstract
{
   public interface IRepository<T,ID> where T : IIdentifiable<ID>
    where ID : IComparable
   {
      T GetByID(ID id);
      
      IEnumerable<T> GetAll();
      
      T Create(T entity);
      
      void Update(T entity);
      
      void Delete(T entity);
      void DeleteById(ID id);
      
      void DeleteAll();      
      IEnumerable<T> FindAll(Func<T, bool> predicate);
   
   }
}