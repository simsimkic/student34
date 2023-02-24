// File:    EquipmentService.cs
// Created: Tuesday, May 26, 2020 2:14:28 PM
// Purpose: Definition of Class EquipmentService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.ManagerService
{
   public class EquipmentService : IService<Equipment, long>
    {
        private readonly IEquipmentRepository Repository;
        public EquipmentService(IEquipmentRepository repository)
        {
            Repository = repository;
        }
        public Equipment Create(Equipment entity) => Repository.Create(entity);

        public void Delete(Equipment entity) => Repository.Delete(entity);

        public Equipment Get(long id) => Repository.GetByID(id);

        public IEnumerable<Equipment> GetAll() => Repository.GetAll();

        public void Update(Equipment entity) => Repository.Update(entity);
        public Equipment BuyEquipment(Equipment equipment)
      {
         throw new NotImplementedException();
      }

       

        public Equipment MoveEquipment(String equipmentID, String fromRoomID, String toRoomID, int quantity)
      {
         throw new NotImplementedException();
      }

        public void DeleteById(long id) => Repository.DeleteById(id);
    }
}