// File:    RegisterUserService.cs
// Created: Monday, May 25, 2020 3:27:42 AM
// Purpose: Definition of Class RegisterUserService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using KlinikaZdravo.Repository.Abstract;

namespace ClassDiagram.Service.UserService
{
   public class RegisterUserService : IService<RegisteredUser, long>
    {
        private readonly IRegisteredUserRepository Repository;

        public RegisterUserService(IRegisteredUserRepository repository)
        {
            Repository = repository;
        }

          public void LogIn(String username, String password)
          {
             throw new NotImplementedException();
          }
      
          public RegisteredUser EditAccount(RegisteredUser user)
          {
             throw new NotImplementedException();
          }
      
          public void LogOut()
          {
             throw new NotImplementedException();
          }
      
          public void ChangeLanguage()
          {
             throw new NotImplementedException();
          }
      
          public Boolean IsPasswordValid(String password)
          {
             throw new NotImplementedException();
          }
      
          public Boolean IsUsernameValid(String username)
          {
             throw new NotImplementedException();
          }
      
          public List<Notifications> ShowNotification()
          {
             throw new NotImplementedException();
          }
      
          public RegisteredUser CreateTemporaryAccount()
          {
             throw new NotImplementedException();
          }
      
          public List<RegisteredUser> ShowAll()
          {
             throw new NotImplementedException();
          }

        public RegisteredUser Get(long id) => Repository.GetByID(id);
        public IEnumerable<RegisteredUser> GetAll() => Repository.GetAll();
        public RegisteredUser Create(RegisteredUser registeredUser) => Repository.Create(registeredUser);
        public void Update(RegisteredUser registeredUser) => Repository.Update(registeredUser);
        public void Delete(RegisteredUser registeredUser) => Repository.Delete(registeredUser);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }
    }
}