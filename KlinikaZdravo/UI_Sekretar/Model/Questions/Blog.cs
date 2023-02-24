// File:    Blog.cs
// Created: Tuesday, June 2, 2020 7:18:18 PM
// Purpose: Definition of Class Blog

using System;
using System.Collections.Generic;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Questions
{
   public class Blog : IIdentifiable<long>
    {
      public long Id { get; set; }
      public List<Article> article;

      public Blog() { }
      public Blog(long id) 
      {
           Id = id;
      }
      public Blog(long id, List<Article> articl) 
      {
            Id = id;
            article = articl;
      }

      public List<Article> Article
      {
         get
         {
            if (article == null)
               article = new List<Article>();
            return article;
         }
         set
         {
            RemoveAllArticle();
            if (value != null)
            {
               foreach (Article oArticle in value)
                  AddArticle(oArticle);
            }
         }
      }
      
      public void AddArticle(Article newArticle)
      {
         if (newArticle == null)
            return;
         if (this.article == null)
            this.article = new System.Collections.Generic.List<Article>();
         if (!this.article.Contains(newArticle))
            this.article.Add(newArticle);
      }
      
      public void RemoveArticle(Article oldArticle)
      {
         if (oldArticle == null)
            return;
         if (this.article != null)
            if (this.article.Contains(oldArticle))
               this.article.Remove(oldArticle);
      }
      
      public void RemoveAllArticle()
      {
         if (article != null)
            article.Clear();
      }

      public long GetId() => Id;

      public void SetId(long id) => Id = id;
    }
}