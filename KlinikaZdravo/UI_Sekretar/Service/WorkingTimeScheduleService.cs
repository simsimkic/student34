// File:    WorkingTimeScheduleService.cs
// Created: Monday, May 25, 2020 3:26:43 AM
// Purpose: Definition of Class WorkingTimeScheduleService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.ManagerService
{
   public class WorkingTimeScheduleService : IService<WorkingHoursSchedule, long>
    {
        private readonly IWorkingScheduleRepository Repository;

        public WorkingTimeScheduleService(IWorkingScheduleRepository repository)
        {
            Repository = repository;
        }
        public WorkingHoursSchedule Create(WorkingHoursSchedule entity) => Repository.Create(entity);

        public void Delete(WorkingHoursSchedule entity) => Repository.Delete(entity);

        public WorkingHoursSchedule Get(long id) => Repository.GetByID(id);

        public IEnumerable<WorkingHoursSchedule> GetAll() => Repository.GetAll();

        public void Update(WorkingHoursSchedule entity) => Repository.Update(entity);
        public Boolean MakeSchedule(Days day, WorkingHoursSchedule workingHours, RegisteredUser employee)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ChangeSchedule(Days day, WorkingHoursSchedule workingHours, RegisteredUser employee)
      {
         throw new NotImplementedException();
      }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }
    }
}