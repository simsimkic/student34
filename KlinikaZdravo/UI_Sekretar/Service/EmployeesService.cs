// File:    EmployeeService.cs
// Created: Tuesday, May 26, 2020 2:14:37 PM
// Purpose: Definition of Class EmployeeService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Repository.Abstract;

namespace ClassDiagram.Service.ManagerService
{
   public class EmployeesService : IService<Employee, long>
    {
        private readonly IEmployeeRepository Repository;

        public EmployeesService(IEmployeeRepository repository)
        {
            Repository = repository;
        }
        public Employee Create(Employee entity) => Repository.Create(entity);
        public void DeleteById(long id) => Repository.DeleteById(id);

        public void Delete(Employee entity) => Repository.Delete(entity);

        public Employee Get(long id) => Repository.GetByID(id);

        public IEnumerable<Employee> GetAll() => Repository.GetAll();

        public void Update(Employee entity) => Repository.Update(entity);

        /*     public Employee RegisterEmpolyee(EmployeeType employee)
           {
              throw new NotImplementedException();
           }

          

           public Employee ChangeEmployee(EmployeeType employee)
           {
              throw new NotImplementedException();
           }*/

      
    }
}