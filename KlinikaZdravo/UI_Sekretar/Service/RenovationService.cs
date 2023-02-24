using ClassDiagram.Model.Rooms;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Service
{
    public class RenovationService : IService<Renovation, long>
    {
        private readonly IRenovationRepository Repository;
        public RenovationService(IRenovationRepository repository)
        {
            Repository = repository;
        }

        public Renovation ChangeTemporaryToPermanent(Renovation renovation)
        {
            throw new NotImplementedException();
        }

        public Renovation Create(Renovation entity) => Repository.Create(entity);

        public void Delete(Renovation entity) => Repository.Delete(entity);

        public void DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public Renovation Get(long id) => Repository.GetByID(id);

        public IEnumerable<Renovation> GetAll() => Repository.GetAll();

        public void Update(Renovation entity) => Repository.Update(entity);
    }
}
