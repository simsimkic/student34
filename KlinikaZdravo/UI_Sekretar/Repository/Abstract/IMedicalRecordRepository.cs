// File:    IMedicalRecordRepository.cs
// Created: Monday, June 22, 2020 8:23:11 PM
// Purpose: Definition of Interface IMedicalRecordRepository

using System;
using ClassDiagram.Model.DoctorExaminations;

namespace ClassDiagram.Repository.Abstract
{
   public interface IMedicalRecordRepository : IRepository<MedicalRecord,long>
   {
   }
}