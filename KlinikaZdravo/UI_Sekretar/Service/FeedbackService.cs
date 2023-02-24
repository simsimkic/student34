// File:    FeedbackService.cs
// Created: Monday, May 25, 2020 4:14:06 AM
// Purpose: Definition of Class FeedbackService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Service.UserService
{
   public class FeedbackService : IService<Feedback, long>
    {
        private readonly IFeedbackRepository Repository;

        public FeedbackService(IFeedbackRepository repository)
        {
            Repository = repository;
        }

        public Feedback AddComment(Feedback comment)
      {
         throw new NotImplementedException();
      }

        public Feedback Create(Feedback feedback) => Repository.Create(feedback);
        public void Delete(Feedback feedback) => Repository.Delete(feedback);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Feedback Get(long id) => Repository.GetByID(id);

        public IEnumerable<Feedback> GetAll() => Repository.GetAll();
        public void Update(Feedback feedback) => Repository.Update(feedback);
    }
}