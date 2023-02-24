// File:    Feedback.cs
// Created: Monday, May 25, 2020 4:15:46 AM
// Purpose: Definition of Class Feedback

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class Feedback : IIdentifiable<long>
    {
        public long Id { get; set; }

        public String Comment { get; set; }

        public Feedback() { }
        public Feedback(long id) 
        {
            Id = id;   
        }
        public Feedback(long id, string comment)
        {
            Id = id;
            Comment = comment;
        }


        public long GetId()
        {
            throw new NotImplementedException();
        }

        public void SetId(long id)
        {
            throw new NotImplementedException();
        }
    }
}