// File:    Drug.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Drug

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Medicine
{
   public class Drug : IIdentifiable<long>
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public String WayToUse { get; set; }
        //    private Status Status;
        public String Manufacturer { get; set; }
        public DateTime ExpirationDate { get; set; }
        public String Type { get; set; }

        public Ingredient Ingredient { get; set; }

        public Drug()
        {

        }
        public Drug(long id)
        {
            Id = id;
        }
        public Drug(long id,string name)
        {
            Id = id;
            Name = name;
            Quantity=12;
            Type = "Analgetik";
        }


        public Drug(long id,string  name,int quantity,string wayToUse/*,Status status,*/,string manufacturer,DateTime expirationDate,string type/*,Ingredient ingredient*/)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            WayToUse = wayToUse;
           // Status = status;
            Manufacturer = manufacturer;
            ExpirationDate= expirationDate;
            Type = type;
          //  Ingredient = ingredient;

        }


        /// <summary>
        /// Property for Ingredient
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Ingredient Ingredients
      {
         get
         {
            return Ingredient;
         }
         set
         {
            if (this.Ingredient == null || !this.Ingredient.Equals(value))
            {
               if (this.Ingredient != null)
               {
                  Ingredient oldIngredient = this.Ingredient;
                  this.Ingredient = null;
                  oldIngredient.RemoveDrug(this);
               }
               if (value != null)
               {
                  this.Ingredient = value;
                  this.Ingredient.AddDrug(this);
               }
            }
         }
      }
      public Allergen allergens;
      
      /// <summary>
      /// Property for Allergen
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Allergen Allergens
      {
         get
         {
            return allergens;
         }
         set
         {
            if (this.allergens == null || !this.allergens.Equals(value))
            {
               if (this.allergens != null)
               {
                  Allergen oldAllergen = this.allergens;
                  this.allergens = null;
                  oldAllergen.RemoveDrug(this);
               }
               if (value != null)
               {
                  this.allergens = value;
                  this.allergens.AddDrug(this);
               }
            }
         }
      }
      public ClassDiagram.Model.Users.Doctor appraiser;
      
      /// <summary>
      /// Property for ClassDiagram.Model.Users.Doctor
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public ClassDiagram.Model.Users.Doctor Appraiser
      {
         get
         {
            return appraiser;
         }
         set
         {
            this.appraiser = value;
         }
      }

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}