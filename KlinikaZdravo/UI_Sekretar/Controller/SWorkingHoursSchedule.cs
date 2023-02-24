// File:    ScheduleController.cs
// Created: Tuesday, June 23, 2020 5:50:44 PM
// Purpose: Definition of Class ScheduleController

using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Repository;
using ClassDiagram.Service.UserService;
using System.Collections.Generic;

namespace ClassDiagram.Controller
{
    public class SWorkingHoursSchedule : IController<WorkingHoursSchedule, long>
    {
        private readonly IService<WorkingHoursSchedule, long> Service;
        private static SWorkingHoursSchedule Instance;

        public SWorkingHoursSchedule(IService<WorkingHoursSchedule, long> service)
        {
            Service = service;
        }
        public static SWorkingHoursSchedule GetInstance(IService<WorkingHoursSchedule, long> service)
        {
            if (Instance == null)
            {
                Instance = new SWorkingHoursSchedule(service);
            }
            return Instance;
        }
        public IEnumerable<WorkingHoursSchedule> GetAll() => Service.GetAll();

        public WorkingHoursSchedule GetByID(long id) => Service.Get(id);

        public WorkingHoursSchedule Create(WorkingHoursSchedule entity) => Service.Create(entity);

        public void Update(WorkingHoursSchedule entity) => Service.Update(entity);

        public void Delete(WorkingHoursSchedule entity) => Service.Delete(entity);
        
        public void DeleteAll()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteById(long v)
        {
            throw new System.NotImplementedException();
        }
    }
}