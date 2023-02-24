using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class NotificationsController : IController<Notifications, long>
    {

        private static NotificationsController Instance;
        private readonly IService<Notifications, long> Service;

        public NotificationsController(IService<Notifications, long> service)
        {
            Service = service;
        }
        public static NotificationsController GetInstance(IService<Notifications, long> service)
        {
            if (Instance == null)
            {
                Instance = new NotificationsController(service);
            }
            return Instance;
        }


        public IEnumerable<Notifications> GetAll() => Service.GetAll();
        public Notifications GetByID(long id) => Service.Get(id);
        public Notifications Create(Notifications notifications) => Service.Create(notifications);
        public void Update(Notifications notifications) => Service.Update(notifications);
        public void Delete(Notifications notifications) => Service.Delete(notifications);
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
