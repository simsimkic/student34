// File:    RoomService.cs
// Created: Tuesday, May 26, 2020 2:14:04 PM
// Purpose: Definition of Class RoomService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.ManagerService
{
    public class RoomService : IService<Room, long>
    {
        private readonly IRoomRepository Repository;
        public RoomService(IRoomRepository repository)
        {
            Repository = repository;
        }

        public Room Create(Room entity) => Repository.Create(entity);

        public void Delete(Room entity) => Repository.Delete(entity);

        public Room Get(long id) => Repository.GetByID(id);

        public IEnumerable<Room> GetAll() => Repository.GetAll();

        public void Update(Room entity) => Repository.Update(entity);

        public Room SplitRoom(String id)
      {
         throw new NotImplementedException();
      }
      
      public Room UndoSplitRoom(String id)
      {
         throw new NotImplementedException();
      }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public RoomRenovationScheduleService roomRenovationScheduleService;
   
   }
}