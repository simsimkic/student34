// File:    VacationScheduleService.cs
// Created: Monday, May 25, 2020 3:26:43 AM
// Purpose: Definition of Class VacationScheduleService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.ManagerService
{
    public class VacationScheduleService : IService<VacationSchedule, long>
    {
        private readonly IVacationScheduleRepository Repository;

        public VacationScheduleService(IVacationScheduleRepository repository)
        {
            Repository = repository;
        }
        public VacationSchedule Create(VacationSchedule entity) => Repository.Create(entity);
        public void DeleteById(long id) => Repository.DeleteById(id);

        public void Delete(VacationSchedule entity) => Repository.Delete(entity);

        public VacationSchedule Get(long id) => Repository.GetByID(id);

        public IEnumerable<VacationSchedule> GetAll() => Repository.GetAll();

        public void Update(VacationSchedule entity) => Repository.Update(entity);

        public Boolean ScheduleVaciation(DateTime fromDay, DateTime toDay, RegisteredUser employee)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CancelVacation(DateTime fromDay, DateTime toDay, RegisteredUser employee)
      {
         throw new NotImplementedException();
      }

        
    }
}