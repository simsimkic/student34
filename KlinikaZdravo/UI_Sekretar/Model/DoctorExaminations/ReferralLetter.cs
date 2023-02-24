// File:    ReferralLetter.cs
// Created: Friday, May 22, 2020 6:26:05 PM
// Purpose: Definition of Class ReferralLetter

using System;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.DoctorExaminations
{
   public class ReferralLetter : IIdentifiable<long>
    {
        public long Id { get; set; }
        public Specialization DoctorSpecialization { get; set; }
        public DateTime IssuingDate { get; set; }

        public ReferralLetter()
        {

        }
        public ReferralLetter(long id)
        {
            Id = id;
        }
        public ReferralLetter(long id, Specialization doctorSpecialization, DateTime issuingDate)
        {
            Id = id;
            DoctorSpecialization = doctorSpecialization;
            IssuingDate = issuingDate;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}