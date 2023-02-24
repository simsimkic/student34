// File:    IEquipmentRepository.cs
// Created: Monday, June 22, 2020 8:20:40 PM
// Purpose: Definition of Interface IEquipmentRepository

using System;
using ClassDiagram.Model.Rooms;

namespace ClassDiagram.Repository.Abstract
{
   public interface IEquipmentRepository : IRepository<Equipment,long>
   {
      EquipmentRepository AddEquipment(ClassDiagram.Model.Rooms.Equipment equipmentType);
   
   }
}