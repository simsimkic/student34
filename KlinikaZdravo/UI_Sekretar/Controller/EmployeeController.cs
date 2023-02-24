// File:    EmployeeController.cs
// Created: Tuesday, June 23, 2020 6:08:19 PM
// Purpose: Definition of Class EmployeeController

using System;
using System.Collections.Generic;
using Aplikacija.Services;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class EmployeeController : IController<Employee,long>
   {
        private static EmployeeController Instance;

        public EmployeeService EquipmentService;
        private readonly IService<Employee, long> Service;
        public EmployeeController(IService<Employee, long> service)
        {
            Service = service;
        }
        public static EmployeeController GetInstance(IService<Employee, long> service)
        {
            if (Instance == null)
            {
                Instance = new EmployeeController(service);
            }
            return Instance;
        }
        public IEnumerable<Employee> GetAll() => Service.GetAll();

        public Employee GetByID(long id) => Service.Get(id);

        public Employee Create(Employee entity) => Service.Create(entity);

        public void Update(Employee entity) => Service.Update(entity);

        public void Delete(Employee entity) => Service.Delete(entity);
        public void DeleteById(long id) => Service.DeleteById(id);

        public EmployeeController GetInstance()
      {
         throw new NotImplementedException();
      }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

   
   }
}