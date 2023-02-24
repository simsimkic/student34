// File:    INotificationRepository.cs
// Created: Monday, June 22, 2020 7:31:10 PM
// Purpose: Definition of Interface INotificationRepository

using System;
using ClassDiagram.Model.Users;
namespace ClassDiagram.Repository.Abstract
{
   public interface INotificationRepository : IRepository<Notifications,long>
   {
   }
}