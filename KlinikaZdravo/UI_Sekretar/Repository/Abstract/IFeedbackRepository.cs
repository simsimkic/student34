// File:    IFeedbackRepository.cs
// Created: Monday, June 22, 2020 7:31:09 PM
// Purpose: Definition of Interface IFeedbackRepository

using System;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Abstract
{
   public interface IFeedbackRepository : IRepository<Feedback, long>
   {
   }
}