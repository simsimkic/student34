// File:    MessageService.cs
// Created: Monday, June 1, 2020 7:40:46 PM
// Purpose: Definition of Class MessageService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.DoctorService
{
   public class MessageService : IService<Notifications, long>
    {
        private readonly INotificationRepository Repository;

      
      public QuestionAndAnswer ReadMessage(QuestionAndAnswer message)
      {
         throw new NotImplementedException();
      }
      
      public List<QuestionAndAnswer> DeliveredMessages(Doctor doctor)
      {
         throw new NotImplementedException();
      }
      
      public List<QuestionAndAnswer> ReceivedMessages(Doctor doctor)
      {
         throw new NotImplementedException();
      }

        public Notifications Get(long id) => Repository.GetByID(id);

        public IEnumerable<Notifications> GetAll() => Repository.GetAll();

        public Notifications Create(Notifications notifications) => Repository.Create(notifications);

        public void Update(Notifications notifications) => Repository.Update(notifications);

        public void Delete(Notifications notifications) => Repository.Delete(notifications);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }
    }
}