// File:    Allergie.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Allergie

using System;
using ClassDiagram.Repository.Abstract;
using healthClinic.podaci;

namespace ClassDiagram.Model.DoctorExaminations
{
   public class Allergie : IIdentifiable<long>
    {

        public long Id { get; set; }
        public String AllergyName { get; set; }

        public Allergie()
        {
        }

        public Allergie(long id)
        {
            Id = id;
        }
        public Allergie(long id,String typeOfAllergie)
        {
            Id = id;
            AllergyName = typeOfAllergie;
        }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}