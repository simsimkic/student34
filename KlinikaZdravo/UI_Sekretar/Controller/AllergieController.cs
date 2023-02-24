using ClassDiagram.Controller;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Medicine;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class AllergieController: IController<Allergie, long>
    {
      private static AllergieController Instance;
    private readonly IService<Allergie, long> Service;

    public AllergieController(IService<Allergie, long> service)
    {
        Service = service;
    }
    public static AllergieController GetInstance(IService<Allergie, long> service)
        {
            if (Instance == null)
            {
                Instance = new AllergieController(service);
            }
            return Instance;
        }

    public Allergie Create(Allergie entity) => Service.Create(entity);
    public void Delete(Allergie entity) => Service.Delete(entity);
    public void Update(Allergie entity) => Service.Update(entity);
    public void DeleteAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Allergie> GetAll() => Service.GetAll();
    public Allergie GetByID(long id) => Service.Get(id);

    public void DeleteById(long v)
    {
        throw new NotImplementedException();
    }
}
}
