using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class NotificationsService : IService<Notifications, long>
    {
        private readonly INotificationRepository Repository;

        public NotificationsService(INotificationRepository repository)
        {
            Repository = repository;
        }
        public Notifications Create(Notifications notifications) => Repository.Create(notifications);
        public void Delete(Notifications notifications) => Repository.Delete(notifications);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Notifications Get(long id) => Repository.GetByID(id);
        public IEnumerable<Notifications> GetAll() => Repository.GetAll();
        public void Update(Notifications notifications) => Repository.Update(notifications);
    }
}
