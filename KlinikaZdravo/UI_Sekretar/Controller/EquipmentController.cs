// File:    EquipmentController.cs
// Created: Tuesday, June 23, 2020 5:50:40 PM
// Purpose: Definition of Class EquipmentController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Service.ManagerService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class EquipmentController : IController<Equipment,long>
   {
        private static EquipmentController Instance;
        public EquipmentController EquipmentControllerB;
        public EquipmentService EquipmentService;
        private readonly IService<Equipment, long> Service;
        public EquipmentController(IService<Equipment, long> service)
        {
            Service = service;
        }
        public static EquipmentController GetInstance(IService<Equipment, long> service)
        {
            if (Instance == null)
            {
                Instance = new EquipmentController(service);
            }
            return Instance;
        }

        public IEnumerable<Equipment> GetAll() => Service.GetAll();

        public Equipment GetByID(long id) => Service.Get(id);

        public Equipment Create(Equipment entity) => Service.Create(entity);

        public void Update(Equipment entity) => Service.Update(entity);

        public void Delete(Equipment entity) => Service.Delete(entity);

        public EquipmentController GetInstance()
      {
         throw new NotImplementedException();
      }
      
      public Equipment BuyEquipment(Equipment equipment)
      {
         throw new NotImplementedException();
      }
      
      public Equipment MoveEquipment(String equipmentID, String fromRoomID, String toRoomID, int quantity)
      {
         throw new NotImplementedException();
      }

       
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long v) => Service.DeleteById(v);
    }
}