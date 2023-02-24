using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class ContactController : IController<Contact, long>
    {

        private static ContactController Instance;
        private readonly IService<Contact, long> Service;

        public ContactController(IService<Contact, long> service)
        {
            Service = service;
        }
        public static ContactController GetInstance(IService<Contact, long> service)
        {
            if (Instance == null)
            {
                Instance = new ContactController(service);
            }
            return Instance;
        }


        public IEnumerable<Contact> GetAll() => Service.GetAll();
        public Contact GetByID(long id) => Service.Get(id);
        public Contact Create(Contact contact) => Service.Create(contact);
        public void Update(Contact contact) => Service.Update(contact);
        public void Delete(Contact contact) => Service.Delete(contact);

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}
