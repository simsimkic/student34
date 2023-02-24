// File:    Article.cs
// Created: Tuesday, June 2, 2020 7:18:18 PM
// Purpose: Definition of Class Article

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Questions
{
   public class Article : IIdentifiable<long>
    {
        public long Id { get; set; }
        private string Title { get; set; }
        private string Content { get; set; }
        private TextType Type;

        public Article() { }
        public Article(long id) 
        {
            Id = id;
        }
        public Article(long id, string title, string content)
        {
            Id = id;
            Title = title;
            Content = content;
        }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}