// File:    PersonalDayService.cs
// Created: Monday, May 25, 2020 3:26:43 AM
// Purpose: Definition of Class PersonalDayService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.ManagerService
{
   public class PersonalDayService : IService<PersonalDay, long>
    {
        private readonly IPersonalDaysRepository Repository;
        public PersonalDayService(IPersonalDaysRepository repository)
        {
            Repository = repository;
        }
        public PersonalDay Create(PersonalDay entity) => Repository.Create(entity);

        public void Delete(PersonalDay entity) => Repository.Delete(entity);

        public PersonalDay Get(long id) => Repository.GetByID(id);

        public IEnumerable<PersonalDay> GetAll() => Repository.GetAll();

        public void Update(PersonalDay entity) => Repository.Update(entity);
        public Boolean SchedulePersonalDay(DateTime day)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CancePersonalDay(DateTime day)
      {
         throw new NotImplementedException();
      }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }
    }
}