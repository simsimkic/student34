// File:    IWorkingScheduleRepository.cs
// Created: Monday, June 22, 2020 7:52:56 PM
// Purpose: Definition of Interface IWorkingScheduleRepository

using System;
using ClassDiagram.Model.WorkingSchedule;

namespace ClassDiagram.Repository.Abstract
{
   public interface IWorkingScheduleRepository : IRepository<WorkingHoursSchedule, long>
   {
      WorkingHoursSchedule GetWorkingScheduleForDoctor(DateTime startDate, DateTime endDate);
      
      WorkingHoursSchedule GetWorkingScheduleForDoctorInPeriod(DateTime startDate, DateTime endDate, ClassDiagram.Model.Users.Doctor doctor);
      
      WorkingHoursSchedule GetWorkingScheduleForDay(ClassDiagram.Model.WorkingSchedule.Days day);
   
   }
}