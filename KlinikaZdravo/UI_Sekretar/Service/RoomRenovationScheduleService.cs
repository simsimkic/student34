// File:    RoomRenovationScheduleService.cs
// Created: Tuesday, May 26, 2020 2:14:17 PM
// Purpose: Definition of Class RoomRenovationScheduleService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.ManagerService
{
   public class RoomRenovationScheduleService : IService<Renovation, long>
    {
        private readonly IRenovationRepository repository;
        private readonly IRoomRepository repository1;

        public Boolean MakeApoitementForRenovation(DateTime fromDay, DateTime toDay, String id)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CancleApoitementForRenovation(String id, Boolean isRenovationCanceled)
      {
         throw new NotImplementedException();
      }

        public Room Get(long id)
        {
            throw new NotImplementedException();
        }

        Renovation IService<Renovation, long>.Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Renovation> GetAll()
        {
            throw new NotImplementedException();
        }

        public Renovation Create(Renovation entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Renovation entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Renovation entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }
    }
}