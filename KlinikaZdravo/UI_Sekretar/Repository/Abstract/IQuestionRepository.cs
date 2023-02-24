// File:    IQuestionRepository.cs
// Created: Monday, June 22, 2020 8:24:51 PM
// Purpose: Definition of Interface IQuestionRepository

using System;
using ClassDiagram.Model.Questions;

namespace ClassDiagram.Repository.Abstract
{
   public interface IQuestionRepository : IRepository<QuestionAndAnswer,long>
   {
   }
}