// File:    HospitalTreatment.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class HospitalTreatment

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.DoctorExaminations
{
   public class HospitalTreatment : IIdentifiable<long>
    {
        public long Id { get; set; }
        private DateTime FromDate { get; set; }
        private DateTime ToDate { get; set; }

        public HospitalTreatment()
        {

        }
        public HospitalTreatment(long id)
        {
            Id = id;
        }
        public HospitalTreatment(long id, DateTime fromDate, DateTime toDate)
        {
            Id = id;
            FromDate = fromDate;
            ToDate = toDate;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}