// File:    BlogCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:10 PM
// Purpose: Definition of Class BlogCSVConverter

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using KlinikaZdravo.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class BlogCSVConverter : ICSVConverter<Blog>
    {
        private readonly string Delimiter;
        public BlogCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Blog ConvertCSVFormatToEntity(string blogCSVFormat)
        {
            string[] tokens = blogCSVFormat.Split(Delimiter.ToCharArray());
            List<Article> articles = new List<Article>();
            ListCSVConverter.convertToLongList(tokens[1]).ForEach(id => articles.Add(new Article(id)));
            return new Blog(
                   long.Parse(tokens[0]),
                   articles);
        }

        public string ConvertEntityToCSVFormat(Blog blog)
         => string.Join(Delimiter,
                           blog.Id,
                           ListCSVConverter.convertToCSVFormat(blog.article));
    }
}