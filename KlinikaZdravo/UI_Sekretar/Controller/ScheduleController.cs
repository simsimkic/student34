// File:    ScheduleController.cs
// Created: Tuesday, June 23, 2020 5:50:44 PM
// Purpose: Definition of Class ScheduleController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Service.ManagerService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class ScheduleController : IController<WorkingHoursSchedule,long>
   {
        private static ScheduleController Instance;
        public ScheduleController ScheduleControllerB;
        public VacationScheduleService VacationScheduleService;
        public WorkingHoursSchedule WorkingHoursSchedule;
        public WorkingTimeScheduleService WorkingTimeScheduleService;

        public ScheduleController(IService<WorkingHoursSchedule, long> service)
        {
            // WorkingHoursSchedule = service;
        }
        public static ScheduleController GeInstance(IService<WorkingHoursSchedule, long> service)
        {
            if (Instance == null)
            {
                Instance = new ScheduleController(service);
            }
            return Instance;
        }


        public Boolean MakeWorkingSchedule(Employee employee,Days day, WorkingHoursSchedule workingHours)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ChangeWorkingSchedule(Employee employee,Days day, WorkingHoursSchedule workingHours)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ScheduleVaciation(DateTime startDate, DateTime endDate, Employee employee)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CancelVacation(DateTime startDate, DateTime endDate, Employee employee)
      {
         throw new NotImplementedException();
      }
      
      public Boolean SchedulePersonalDay(Days day)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CancePersonalDay(Days day)
      {
         throw new NotImplementedException();
      }
      
      public void GetDoctorsScheduleForDay()
      {
         throw new NotImplementedException();
      }

        public IEnumerable<WorkingHoursSchedule> GetAll()
        {
            throw new NotImplementedException();
        }

        public WorkingHoursSchedule GetByID(long id)
        {
            throw new NotImplementedException();
        }

        

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<WorkingHoursSchedule> IController<WorkingHoursSchedule, long>.GetAll()
        {
            throw new NotImplementedException();
        }

        WorkingHoursSchedule IController<WorkingHoursSchedule, long>.GetByID(long id)
        {
            throw new NotImplementedException();
        }

        public WorkingHoursSchedule Create(WorkingHoursSchedule entity)
        {
            throw new NotImplementedException();
        }

        public void Update(WorkingHoursSchedule entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(WorkingHoursSchedule entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}