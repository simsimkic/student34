// File:    BlogService.cs
// Created: Thursday, May 28, 2020 5:19:00 PM
// Purpose: Definition of Class BlogService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Repository;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.BlogService
{
   public class BlogService : IService<Blog, long>
    {
        private readonly IBlogRepository repository;
        private BlogRepository blogRepository;

        public BlogService(BlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }
        private readonly IBlogRepository Repository;

        public BlogService(IBlogRepository repository)
        {
            Repository = repository;
        }


        public Blog Create(Blog blog) => Repository.Create(blog);

        public void Delete(Blog blog) => Repository.Delete(blog);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Blog Get(long id) => Repository.GetByID(id);

        public IEnumerable<Blog> GetAll() => Repository.GetAll();

        public Blog ReadBlog()
      {
         throw new NotImplementedException();
      }

        public void Update(Blog blog) => Repository.Update(blog);
    }
}