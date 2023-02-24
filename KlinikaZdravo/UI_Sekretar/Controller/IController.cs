// File:    IController.cs
// Created: Tuesday, June 23, 2020 5:38:57 PM
// Purpose: Definition of Interface IController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.SecretaryService;

namespace ClassDiagram.Controller
{
   public interface IController<T,ID> where T : class
   {
      IEnumerable<T> GetAll();
      
      T GetByID(ID id);
      
      T Create(T entity);
      
      void Update(T entitiy);
      
      void Delete(T entity);
      
      void DeleteAll();
      void DeleteById(long id);
    }
}