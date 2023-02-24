// File:    IBlogRepository.cs
// Created: Monday, June 22, 2020 7:43:48 PM
// Purpose: Definition of Interface IBlogRepository

using System;
using ClassDiagram.Model.Questions;

namespace ClassDiagram.Repository.Abstract
{
   public interface IBlogRepository : IRepository<Blog,long>
   {
   }
}