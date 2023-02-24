// File:    ICSVConverter.cs
// Created: Monday, June 22, 2020 9:15:13 PM
// Purpose: Definition of Interface ICSVConverter

using System;

namespace ClassDiagram.Repository.Csv.Converter
{
   public interface ICSVConverter<T> where T : class
   {
      string ConvertEntityToCSVFormat(T entity);
      
      T ConvertCSVFormatToEntity(string entityCSVFormat);
   
   }
}