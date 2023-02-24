// File:    IRoomRepository.cs
// Created: Monday, June 22, 2020 7:52:55 PM
// Purpose: Definition of Interface IRoomRepository

using System;
using ClassDiagram.Model.Rooms;

namespace ClassDiagram.Repository.Abstract
{
   public interface IRoomRepository : IRepository<Room,long>
   {
      ClassDiagram.Model.Rooms.Bed SetBedInfo(ClassDiagram.Model.Users.Patient patient);
   
   }
}