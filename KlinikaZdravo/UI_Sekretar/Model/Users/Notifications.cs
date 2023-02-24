// File:    Notifications.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Notifications

using System;
using System.Collections.Generic;
using ClassDiagram.Repository.Abstract;
using iTextSharp.text;

namespace ClassDiagram.Model.Users
{
   public class Notifications : IIdentifiable<long>
    {
        public long Id { get; set; }
        public String Messages { get; set; }
        public String Content { get; set; }

        public long RegisteredUsers;

        public Notifications() { }
        public Notifications(long id) 
        {
            Id = id;
            RegisteredUsers = 0;
        }
        public Notifications(long id, string messages, string content)
        {
            Id = id;
            Messages = messages;
            Content = content;
        }
        public Notifications(long id, string messages, string content, long registeredUsers) 
        {
            Id = id;
            Messages = messages;
            Content = content;
            RegisteredUsers = registeredUsers;
        }

     
        public long GetId() => Id;

        public void SetId(long id) => Id = id;

    }
}