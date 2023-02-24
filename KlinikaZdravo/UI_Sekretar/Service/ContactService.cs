using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class ContactService : IService<Contact, long>
    {
        private readonly IContactRepository Repository;
        public ContactService(IContactRepository repository)
        {
            Repository = repository;
        }
        public Contact Create(Contact contact) => Repository.Create(contact);
        public void Delete(Contact contact) => Repository.Delete(contact);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Contact Get(long id) => Repository.GetByID(id);
        public IEnumerable<Contact> GetAll() => Repository.GetAll();
        public void Update(Contact contact) => Repository.Update(contact); 
    }
}
