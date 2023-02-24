// File:    RecommendTerms.cs
// Created: Saturday, May 30, 2020 5:58:33 PM
// Purpose: Definition of Class RecommendTerms

using System;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.DoctorExaminations
{
   public class RecommendTerms : IIdentifiable<long>
    {
        public long Id { get; set; }
        private Doctor RecommendDoctor { get; set; }
        private DateTime Date { get; set; }
        private Priority Priority { get; set; }

        public RecommendTerms()
        {

        }
        public RecommendTerms(long id)
        {
            Id = id;
        }
        public RecommendTerms(long id, Doctor recommendDoctor, DateTime date, Priority priority)
        {
            Id = id;
            RecommendDoctor = recommendDoctor;
            Date = date;
            Priority = priority;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}