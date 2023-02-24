// File:    Therapy.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Therapy

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.DoctorExaminations
{
   public class Therapy : IIdentifiable<long>
    {
        public long Id { get; set; }
        private String Tips { get; set; }

        public Therapy()
        {

        }
        public Therapy(long id)
        {
            Id = id;
        }
        public Therapy(long id, String tips)
        {
            Id = id;
            Tips = tips;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}