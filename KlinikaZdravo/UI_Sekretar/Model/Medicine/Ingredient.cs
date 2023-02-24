// File:    Ingredient.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Ingredient

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Medicine
{
   public class Ingredient : IIdentifiable<long>
    {
        public long Id { get; set; }
        private String Name { get; set; }
        public Ingredient()
        {

        }
        public Ingredient(long id)
        {
            Id = id;
        }
        public Ingredient(long id,string name)
        {
            Id = id;
            Name = name;
        }

        public System.Collections.Generic.List<Drug> drug;
      
      /// <summary>
      /// Property for collection of Drug
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Drug> Drug
      {
         get
         {
            if (drug == null)
               drug = new System.Collections.Generic.List<Drug>();
            return drug;
         }
         set
         {
            RemoveAllDrug();
            if (value != null)
            {
               foreach (Drug oDrug in value)
                  AddDrug(oDrug);
            }
         }
      }
      
      /// <summary>
      /// Add a new Drug in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddDrug(Drug newDrug)
      {
         if (newDrug == null)
            return;
         if (this.drug == null)
            this.drug = new System.Collections.Generic.List<Drug>();
         if (!this.drug.Contains(newDrug))
         {
            this.drug.Add(newDrug);
            newDrug.Ingredients = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Drug from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveDrug(Drug oldDrug)
      {
         if (oldDrug == null)
            return;
         if (this.drug != null)
            if (this.drug.Contains(oldDrug))
            {
               this.drug.Remove(oldDrug);
               oldDrug.Ingredients = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Drug from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllDrug()
      {
         if (drug != null)
         {
            System.Collections.ArrayList tmpDrug = new System.Collections.ArrayList();
            foreach (Drug oldDrug in drug)
               tmpDrug.Add(oldDrug);
            drug.Clear();
            foreach (Drug oldDrug in tmpDrug)
               oldDrug.Ingredients = null;
            tmpDrug.Clear();
         }
      }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}