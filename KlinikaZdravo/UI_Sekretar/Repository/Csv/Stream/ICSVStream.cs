// File:    ICSVStream.cs
// Created: Monday, June 22, 2020 9:27:48 PM
// Purpose: Definition of Interface ICSVStream

using System;
using System.Collections.Generic;

namespace ClassDiagram.Repository.Csv.Stream
{
   public interface ICSVStream<T>
   {
      void SaveAll(IEnumerable<T> entities);
      
      void AppendToFile(T entity);
      
      IEnumerable<T> ReadAll();
   
   }
}