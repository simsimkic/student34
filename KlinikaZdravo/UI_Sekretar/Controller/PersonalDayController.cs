using ClassDiagram.Controller;
using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Service.ManagerService;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class PersonalDayController : IController<PersonalDay, long>

    {
        public PersonalDayService PersonalDayService;
        private readonly IService<PersonalDay, long> Service;
        private static PersonalDayController Instance;
        public PersonalDayController(IService<PersonalDay, long> service)
        {
            Service = service;
        }
        public static PersonalDayController GetInstance(IService<PersonalDay, long> service)
        {
            if (Instance == null)
            {
                Instance = new PersonalDayController(service);
            }
            return Instance;
        }
        public IEnumerable<PersonalDay> GetAll() => Service.GetAll();

        public PersonalDay GetByID(long id) => Service.Get(id);

        public PersonalDay Create(PersonalDay entity) => Service.Create(entity);

        public void Update(PersonalDay entity) => Service.Update(entity);

        public void Delete(PersonalDay entity) => Service.Delete(entity);
        
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
