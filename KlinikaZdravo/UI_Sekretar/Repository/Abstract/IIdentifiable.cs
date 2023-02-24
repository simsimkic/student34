// File:    IIdentifiable.cs
// Created: Monday, June 22, 2020 5:45:12 PM
// Purpose: Definition of Interface IIdentifiable

using System;
using ClassDiagram.Model.DoctorExaminations;

namespace ClassDiagram.Repository.Abstract
{
   public interface IIdentifiable<T>
   {
        T GetId();
      
        void SetId(T id);
   
   }
}