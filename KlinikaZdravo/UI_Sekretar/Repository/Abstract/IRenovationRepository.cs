// File:    IRenovationRepository.cs
// Created: Monday, June 22, 2020 8:18:47 PM
// Purpose: Definition of Interface IRenovationRepository

using System;
using ClassDiagram.Model.Rooms;

namespace ClassDiagram.Repository.Abstract
{
   public interface IRenovationRepository : IRepository<Renovation,long>
   {
      RenovationRepository ScheduleRenovation(DateTime startDate, DateTime endDate, ClassDiagram.Model.Rooms.Room roomId);
   
   }
}