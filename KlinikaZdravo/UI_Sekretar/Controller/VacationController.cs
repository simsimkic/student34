using ClassDiagram.Controller;
using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Service.ManagerService;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class VacationController : IController<VacationSchedule, long>
    {
        private static VacationController Instance;
        private VacationScheduleService vacationService;
        private readonly IService<VacationSchedule, long> Service;

        public VacationController(IService<VacationSchedule, long> vacationService)
        {
            Service = vacationService;
        }
                
        public static VacationController GetInstance(IService<VacationSchedule, long> service)
        {
            if (Instance == null)
            {
                Instance = new VacationController(service);
            }
            return Instance;
        }
        public VacationSchedule Create(VacationSchedule user) => Service.Create(user);
        public void Delete(VacationSchedule user) => Service.Delete(user);
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VacationSchedule> GetAll() => Service.GetAll();
        public VacationSchedule GetByID(long id) => Service.Get(id);
        public void Update(VacationSchedule user) => Service.Update(user);
       
        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }

       
    }
}
