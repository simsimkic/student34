// File:    IReportRepository.cs
// Created: Monday, June 22, 2020 7:31:09 PM
// Purpose: Definition of Interface IReportRepository

using System;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Abstract
{
   public interface IReportRepository : IRepository<Report,long>
   {
   }
}