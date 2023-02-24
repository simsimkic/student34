// File:    QuestionService.cs
// Created: Monday, May 25, 2020 3:28:50 AM
// Purpose: Definition of Class QuestionService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.PatientService
{
   public class QuestionService : IService<QuestionAndAnswer, long>
    { 
        private readonly IQuestionRepository repository;
        private readonly IQuestionRepository Repository;

        public QuestionService(IQuestionRepository repository)
        {
            Repository = repository;
        }

        public QuestionAndAnswer AskQuestion()
      {
         throw new NotImplementedException();
      }

        public QuestionAndAnswer Create(QuestionAndAnswer questionAndAnswer) => Repository.Create(questionAndAnswer);

        public void Delete(QuestionAndAnswer questionAndAnswer) => Repository.Delete(questionAndAnswer);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public QuestionAndAnswer Get(long id) => Repository.GetByID(id);

        public IEnumerable<QuestionAndAnswer> GetAll() => Repository.GetAll();

        public void Update(QuestionAndAnswer questionAndAnswer) => Repository.Update(questionAndAnswer);
    }
}