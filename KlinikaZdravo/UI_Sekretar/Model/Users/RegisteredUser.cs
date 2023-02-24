// File:    RegisteredUser.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class RegisteredUser

using System;
using System.Collections.Generic;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
    public class RegisteredUser : User
    {
        public String Username { get; set; }
        public String Password { get; set; }

        public List<Notifications> Notifications;

        public RegisteredUser() { }
        public RegisteredUser(long id, string name, string surname, DateTime dateOfBirth, string personalId) : this(id)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            PersonalId = personalId;
        }
        public RegisteredUser(long id,string name,string surname):base(id,name,surname) 
        { 

        }
        public RegisteredUser(long id) : base(id)
        {
            Notifications = new List<Notifications>();
        }

        public RegisteredUser(long id, string username, string password, List<Notifications> notifications) :base(id)
        {    
            Username = username;
            Password = password;
            Notifications = notifications;
        }
    
      /// <summary>
      /// Add a new Notifications in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddNotifications(Notifications newNotifications)
      {
         if (newNotifications == null)
            return;
         if (this.Notifications == null)
            this.Notifications = new System.Collections.Generic.List<Notifications>();
         if (!this.Notifications.Contains(newNotifications))
            this.Notifications.Add(newNotifications);
      }
      
      /// <summary>
      /// Remove an existing Notifications from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveNotifications(Notifications oldNotifications)
      {
         if (oldNotifications == null)
            return;
         if (this.Notifications != null)
            if (this.Notifications.Contains(oldNotifications))
               this.Notifications.Remove(oldNotifications);
      }
      
      /// <summary>
      /// Remove all instances of Notifications from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllNotifications()
      {
         if (Notifications != null)
                Notifications.Clear();
      }

    }
}