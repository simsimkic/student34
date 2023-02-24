// File:    FeedbackService.cs
// Created: Monday, May 25, 2020 4:14:06 AM
// Purpose: Definition of Class FeedbackService

using System.Collections.Generic;

namespace ClassDiagram.Service.UserService
{
    public interface IService<T, ID> where T : class
    {
        T Get(ID id);
        IEnumerable<T> GetAll();
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(long id);
    }
}