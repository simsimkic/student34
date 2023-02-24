// File:    IExaminationRepository.cs
// Created: Monday, June 22, 2020 7:47:42 PM
// Purpose: Definition of Interface IExaminationRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;

namespace ClassDiagram.Repository.Abstract
{
   public interface IExaminationRepository : IRepository<Examination,long>
   {
      IEnumerable<ExaminationRepository> GetScheduledExaminationForDoctorsInPeriod(ClassDiagram.Model.Users.Doctor doctor, DateTime startDate, DateTime endDate);
      
      IEnumerable<ExaminationRepository> GetScheduledExaminationPeriod(DateTime startDate, DateTime endDate);
   
   }
}