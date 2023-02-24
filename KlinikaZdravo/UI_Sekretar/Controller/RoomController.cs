// File:    RoomController.cs
// Created: Tuesday, June 23, 2020 5:50:43 PM
// Purpose: Definition of Class RoomController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Service.ManagerService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class RoomController : IController<Room,long>
    {
        private static RoomController Instance;
        public RoomController RoomControllerB;
        public RoomRenovationScheduleService RoomRenovationScheduleService;
        public RoomService RoomService;
        private readonly IService<Room, long> Service;
        public RoomController(IService<Room, long> service)
        {
            Service = service;
        }
        public static RoomController GetInstance(IService<Room, long> service)
        {
            if (Instance == null)
            {
                Instance = new RoomController(service);
            }
            return Instance;
        }
        public IEnumerable<Room> GetAll() => Service.GetAll();

        public Room GetByID(long id) => Service.Get(id);

        public Room Create(Room entity) => Service.Create(entity);

        public void Update(Room entity) => Service.Update(entity);

        public void Delete(Room entity) => Service.Delete(entity);

        public RoomController GetInstance()
      {
         throw new NotImplementedException();
      }
      
      public ClassDiagram.Model.Rooms.Room SplitRoom(String id)
      {
         throw new NotImplementedException();
      }
      
      public ClassDiagram.Model.Rooms.Room UndoSplitRoom(String id)
      {
         throw new NotImplementedException();
      }
      
      public Boolean MakeApoitementForRenovation(DateTime startDate, DateTime endDate, String id)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CancleApoitementForRenovation(String id, Boolean isRenovationCanceled)
      {
         throw new NotImplementedException();
      }

       
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}