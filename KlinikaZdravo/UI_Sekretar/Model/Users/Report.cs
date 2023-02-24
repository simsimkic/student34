// File:    Report.cs
// Created: Thursday, May 28, 2020 9:04:09 PM
// Purpose: Definition of Class Report

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class Report : IIdentifiable<long>
    {
        public long Id { get; set; }
        public String Content { get; set; }

        public Report() {}
        public Report(long id) 
        {
            Id = id;
        }
        public Report(long id, string content) 
        {
            Id = id;
            Content = content;
        }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}