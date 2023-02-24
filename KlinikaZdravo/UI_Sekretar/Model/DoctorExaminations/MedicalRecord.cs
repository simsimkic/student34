// File:    MedicalRecord.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class MedicalRecord

using System;
using System.Collections.Generic;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.DoctorExaminations
{
   public class MedicalRecord : IIdentifiable<long>
    {
        public long Id { get; set; }
        private String CodeNumber { get; set; }

        public List<Allergie> Allergies { get; set; }
        public List<Vaccine> Vaccines { get; set; }
        public List<Prescription> Prescriptions { get; set; }

        public MedicalRecord()
        {

        }
        public MedicalRecord(long id)
        {
            Id = id;
        }
        public MedicalRecord(long id, List<Allergie> allergies,List<Vaccine> vaccines, List<Prescription> prescriptions)
        {
            Id = id;
            Allergies = allergies;
            Vaccines = vaccines;
            Prescriptions = prescriptions;
        }
        /// <summary>
        /// Property for collection of Allergie
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<Allergie> AllergieCollection
      {
         get
         {
            if (Allergies == null)
                    Allergies = new List<Allergie>();
            return Allergies;
         }
         set
         {
            RemoveAllAllergies();
            if (value != null)
            {
               foreach (Allergie oAllergie in value)
                  AddAllergie(oAllergie);
            }
         }
      }
        /// <summary>
        /// Property for collection of Examination
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>

        /// <summary>
        /// Add a new Allergie in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddAllergie(Allergie newAllergie)
      {
         if (newAllergie == null)
            return;
         if (Allergies == null)
                Allergies = new List<Allergie>();
         if (!Allergies.Contains(newAllergie))
                Allergies.Add(newAllergie);
      }  

      
      /// <summary>
      /// Remove an existing Allergie from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAllergies(Allergie oldAllergie)
      {
         if (oldAllergie == null)
            return;
         if (Allergies != null)
            if (Allergies.Contains(oldAllergie))
                    Allergies.Remove(oldAllergie);
      }

      
      /// <summary>
      /// Remove all instances of Allergie from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAllergies()
      {
         if (Allergies != null)
                Allergies.Clear();
      }


        /// <summary>
        /// Property for collection of Vaccine
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<Vaccine> VaccineCollection
      {
         get
         {
            if (Vaccines == null)
                    Vaccines = new List<Vaccine>();
            return Vaccines;
         }
         set
         {
            RemoveAllVaccine();
            if (value != null)
            {
               foreach (Vaccine oVaccine in value)
                  AddVaccine(oVaccine);
            }
         }
      }
      
      /// <summary>
      /// Add a new Vaccine in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddVaccine(Vaccine newVaccine)
      {
         if (newVaccine == null)
            return;
         if (Vaccines == null)
                Vaccines = new List<Vaccine>();
         if (!Vaccines.Contains(newVaccine))
                Vaccines.Add(newVaccine);
      }
      
      /// <summary>
      /// Remove an existing Vaccine from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveVaccine(Vaccine oldVaccine)
      {
         if (oldVaccine == null)
            return;
         if (Vaccines != null)
            if (Vaccines.Contains(oldVaccine))
                    Vaccines.Remove(oldVaccine);
      }
      
      /// <summary>
      /// Remove all instances of Vaccine from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllVaccine()
      {
         if (Vaccines != null)
                Vaccines.Clear();
      }
      
      /// <summary>
      /// Property for collection of Prescription
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public List<Prescription> PrescriptionCollection
      {
         get
         {
            if (Prescriptions == null)
                    Prescriptions = new List<Prescription>();
            return Prescriptions;
         }
         set
         {
            RemoveAllPrescription();
            if (value != null)
            {
               foreach (Prescription oPrescription in value)
                  AddPrescription(oPrescription);
            }
         }
      }
      
      /// <summary>
      /// Add a new Prescription in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPrescription(Prescription newPrescription)
      {
         if (newPrescription == null)
            return;
         if (Prescriptions == null)
                Prescriptions = new List<Prescription>();
         if (!Prescriptions.Contains(newPrescription))
                Prescriptions.Add(newPrescription);
      }
      
      /// <summary>
      /// Remove an existing Prescription from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePrescription(Prescription oldPrescription)
      {
         if (oldPrescription == null)
            return;
         if (Prescriptions != null)
            if (Prescriptions.Contains(oldPrescription))
                    Prescriptions.Remove(oldPrescription);
      }
      
      /// <summary>
      /// Remove all instances of Prescription from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPrescription()
      {
         if (Prescriptions != null)
                Prescriptions.Clear();
      }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}