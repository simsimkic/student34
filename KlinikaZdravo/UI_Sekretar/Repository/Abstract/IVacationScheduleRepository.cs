// File:    IVacationScheduleRepository.cs
// Created: Monday, June 22, 2020 7:52:57 PM
// Purpose: Definition of Interface IVacationScheduleRepository

using System;
using ClassDiagram.Model.WorkingSchedule;

namespace ClassDiagram.Repository.Abstract
{
   public interface IVacationScheduleRepository : IRepository<VacationSchedule,long>
   {
      VacationSchedule GetVacationSchedule(DateTime startDate, DateTime endDate, ClassDiagram.Model.Users.Employee employee);
      
      VacationSchedule SetVacationSchedule(ClassDiagram.Model.Users.Employee employeeId);
   
   }
}