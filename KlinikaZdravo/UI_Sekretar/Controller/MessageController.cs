// File:    MessageController.cs
// Created: Tuesday, June 23, 2020 5:50:41 PM
// Purpose: Definition of Class MessageController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.DoctorService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class MessageController : IController<QuestionAndAnswer, long>
   {
        private static MessageController Instance;

        private readonly IService<QuestionAndAnswer, long> Service;


        public MessageController(IService<QuestionAndAnswer, long> service)
        {
            Service = service;
        }
        public static MessageController GetInstance(IService<QuestionAndAnswer, long> service)
        {
            if (Instance == null)
            {
                Instance = new MessageController(service);
            }
            return Instance;
        }




        public IEnumerable<QuestionAndAnswer> GetAll() => Service.GetAll();

        public QuestionAndAnswer GetByID(long id) => Service.Get(id);

        public QuestionAndAnswer Create(QuestionAndAnswer notifications) => Service.Create(notifications);
        public void Update(QuestionAndAnswer notifications) => Service.Update(notifications);

        public void Delete(QuestionAndAnswer notifications) => Service.Delete(notifications);

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