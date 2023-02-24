// File:    QuestionAndAnswer.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class QuestionAndAnswer

using System;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Questions
{
   public class QuestionAndAnswer : IIdentifiable<long>
    {
        public long Id { get; set; }
        public String Subject { get; set; }
        public String Content { get; set; }

        public Doctor Doktor;
        public Patient Pacijent;

        public QuestionAndAnswer() { }
        public QuestionAndAnswer(long id) 
        {
            Id = id;
        }
        public QuestionAndAnswer(long id, string subject, string content, Doctor doktor, Patient pacijent) 
        {
            Id = id;
            Subject = subject;
            Content = content;
            Doktor = doktor;
            Pacijent = pacijent;

        }

      public Patient Patient
      {
         get
         {
            return Pacijent;
         }
         set
         {
            this.Pacijent = value;
         }
      }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}