// File:    QuestionController.cs
// Created: Tuesday, June 23, 2020 5:50:37 PM
// Purpose: Definition of Class QuestionController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Service.BlogService;
using ClassDiagram.Service.PatientService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class QuestionController : IController<QuestionAndAnswer,long>
   {
        private static QuestionController Instance;
        private readonly IService<Survey, long> ServiceSurvey;
        private readonly IService<QuestionAndAnswer, long> ServiceQuestions;
        private readonly IService<Blog, long> ServiceBlog;

        public QuestionController(IService<QuestionAndAnswer, long> service)
        {
            ServiceQuestions = service;

        }
        public static QuestionController GetInstance(IService<QuestionAndAnswer, long> service)
        {
            if (Instance == null)
            {
                Instance = new QuestionController(service);
            }
            return Instance;
        }

        public QuestionAndAnswer AskQuestion(QuestionAndAnswer question)
      {
         throw new NotImplementedException();
      }
      
      public Blog ReadBlog(Blog blog)
      {
            throw new NotImplementedException();
      }

        public ClassDiagram.Model.Questions.Survey CompleteSurvey(ClassDiagram.Model.Questions.Survey survey)
      {
         throw new NotImplementedException();
      }
      
      public List<String> SaveAnswer()
      {
         throw new NotImplementedException();
      }

        public IEnumerable<QuestionAndAnswer> GetAll() => ServiceQuestions.GetAll();

        public QuestionAndAnswer GetByID(long id) => ServiceQuestions.Get(id);

        public QuestionAndAnswer Create(QuestionAndAnswer questionAndAAnswer) => ServiceQuestions.Create(questionAndAAnswer);

        public void Update(QuestionAndAnswer questionAndAnswer) => ServiceQuestions.Update(questionAndAnswer);

        public void Delete(QuestionAndAnswer questionAndAnswer) => ServiceQuestions.Delete(questionAndAnswer); 

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