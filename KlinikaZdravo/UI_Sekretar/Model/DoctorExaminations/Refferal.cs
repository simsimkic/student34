// File:    Refferal.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Refferal

using System;
using System.Collections.Generic;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.DoctorExaminations
{
   public class Refferal : IIdentifiable<long>
    {
        public long Id { get; set; }
        private String AdditionalInfo { get; set; }

        public List<HospitalTreatment> HospitalTreatments;
      public Refferal() { }
      public Refferal(long id) {
            Id = id;
      }
        public Refferal(long id, String additionalInfo, List<HospitalTreatment> hospitalTreatments)
        {
            Id = id;
            AdditionalInfo = additionalInfo;
            HospitalTreatments = hospitalTreatments;
        }
        /// <summary>
        /// Property for collection of HospitalTreatment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<HospitalTreatment> HospitalTreatmentCollection
      {
         get
         {
            if (HospitalTreatments == null)
                    HospitalTreatments = new List<HospitalTreatment>();
            return HospitalTreatments;
         }
         set
         {
            RemoveAllHospitalTreatment();
            if (value != null)
            {
               foreach (HospitalTreatment oHospitalTreatment in value)
                  AddHospitalTreatment(oHospitalTreatment);
            }
         }
      }
      
      /// <summary>
      /// Add a new HospitalTreatment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddHospitalTreatment(HospitalTreatment newHospitalTreatment)
      {
         if (newHospitalTreatment == null)
            return;
         if (HospitalTreatments == null)
                HospitalTreatments = new System.Collections.Generic.List<HospitalTreatment>();
         if (!HospitalTreatments.Contains(newHospitalTreatment))
                HospitalTreatments.Add(newHospitalTreatment);
      }
      
      /// <summary>
      /// Remove an existing HospitalTreatment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveHospitalTreatment(HospitalTreatment oldHospitalTreatment)
      {
         if (oldHospitalTreatment == null)
            return;
         if (HospitalTreatments != null)
            if (HospitalTreatments.Contains(oldHospitalTreatment))
                    HospitalTreatments.Remove(oldHospitalTreatment);
      }
      
      /// <summary>
      /// Remove all instances of HospitalTreatment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllHospitalTreatment()
      {
         if (HospitalTreatments != null)
                HospitalTreatments.Clear();
      }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}