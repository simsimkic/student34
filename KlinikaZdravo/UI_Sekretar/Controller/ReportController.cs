// File:    ReportController.cs
// Created: Tuesday, June 23, 2020 5:50:42 PM
// Purpose: Definition of Class ReportController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class ReportController : IController<Report,long>
   {
        private static ReportController Instance;
        private readonly IService<Report, long> Service;

        public ReportController(IService<Report, long> service)
        {
            Service = service;
        }

        public static ReportController GetInstance(IService<Report, long> service)
        {
            if (Instance == null)
            {
                Instance = new ReportController(service);
            }
            return Instance;
        }

        public void CreateReport(DateTime startDate, DateTime endDate)
          {
             throw new NotImplementedException();
          }

        public IEnumerable<Report> GetAll()
        {
            throw new NotImplementedException();
        }

        public Report GetByID(long id)
        {
            throw new NotImplementedException();
        }

        public Report Create(Report entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Report entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Report entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}