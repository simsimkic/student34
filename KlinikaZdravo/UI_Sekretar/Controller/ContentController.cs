// File:    ContentController.cs
// Created: Tuesday, June 23, 2020 5:50:35 PM
// Purpose: Definition of Class ContentController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class ContentController : IController<Article, long>
   {

        public ContentController ContentControllerB;
        public FeedbackService FeedbackService;
        private static ContentController Instance;
        private readonly IService<Blog, long> Service;
        private readonly IService<Article, long> ServiceF;


        public ContentController(IService<Blog, long> service)
        {
            Service = service;

        }
        public static ContentController GetInstance(IService<Blog, long> service)
        {
            if (Instance == null)
            {
                Instance = new ContentController(service);
            }
            return Instance;
        }
        public String AddArticle(String text)
        {
           throw new NotImplementedException();
        }
      
        public RegisteredUser AddComment(RegisteredUser comment)
        {
           throw new NotImplementedException();
        }
        public Blog GetByID(long id) => Service.Get(id);

        public Blog Create(Blog blog) => Service.Create(blog);

        public void Update(Blog blog) => Service.Update(blog);

        public void Delete(Blog blog) => Service.Delete(blog);

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        Article IController<Article, long>.GetByID(long id) => ServiceF.Get(id);
        public Article Create(Article article) => ServiceF.Create(article);
        public void Update(Article article) => ServiceF.Update(article);
        public void Delete(Article article) => ServiceF.Delete(article);
        public IEnumerable<Article> GetAll() => ServiceF.GetAll();

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}