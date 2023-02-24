// File:    IPersonalDaysRepository.cs
// Created: Monday, June 22, 2020 7:52:58 PM
// Purpose: Definition of Interface IPersonalDaysRepository

using System;
using ClassDiagram.Model.WorkingSchedule;

namespace ClassDiagram.Repository.Abstract
{
   public interface IPersonalDaysRepository : IRepository<PersonalDay,long>
   {
      PersonalDaysRepository GetPersonalDay(ClassDiagram.Model.Users.Employee employeeId);
      
      PersonalDaysRepository SetPersonalDay(ClassDiagram.Model.Users.Employee employeeId, ClassDiagram.Model.WorkingSchedule.Days day);
   
   }
}