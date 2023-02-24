// File:    IRefferalToHospitalTreatmentRepository.cs
// Created: Monday, June 22, 2020 9:25:29 PM
// Purpose: Definition of Interface IRefferalToHospitalTreatmentRepository

using System;
using ClassDiagram.Model.DoctorExaminations;

namespace ClassDiagram.Repository.Abstract
{
   public interface IRefferalToHospitalTreatmentRepository : IRepository<Refferal,long>
   {
   }
}