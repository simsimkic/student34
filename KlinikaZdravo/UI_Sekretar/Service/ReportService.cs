// File:    ReportService.cs
// Created: Tuesday, May 26, 2020 2:28:47 PM
// Purpose: Definition of Class ReportService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Service.UserService
{
   public class ReportService : IService<Report, long>
    {
        private readonly IReportRepository Repository;

        public ReportService(IReportRepository repository)
        {
            Repository = repository;
        }

        public Report Create(Report entity)
        {
            throw new NotImplementedException();
        }

        public void CreateReport(DateTime fromDate, DateTime toDate)
      {
         throw new NotImplementedException();
      }

        public void Delete(Report entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Report Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Report> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Report entity)
        {
            throw new NotImplementedException();
        }
    }
}