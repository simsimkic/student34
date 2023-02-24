// File:    SurveyService.cs
// Created: Monday, May 25, 2020 3:28:50 AM
// Purpose: Definition of Class SurveyService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.PatientService
{
   public class SurveyService : IService<Survey, long>
    {
      private readonly ISurveyRepository Repository;


        public Survey CompletingSurvey(QuestionSurvey question)
      {
         throw new NotImplementedException();
      }

        public Survey Create(Survey survey) => Repository.Create(survey);

        public void Delete(Survey survey) => Repository.Delete(survey);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Survey Get(long id) => Repository.GetByID(id);

        public IEnumerable<Survey> GetAll() => Repository.GetAll();

        public void Update(Survey survey) => Repository.Update(survey);
    }
}