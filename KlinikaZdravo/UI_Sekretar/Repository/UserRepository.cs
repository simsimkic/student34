using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository
{
    public class UserRepository : CSVRepository<User, long>,
         IUserRepository,
         IEagerCSVRepository<User, long>
    {
        private const string ENTITY_NAME = "Doctor";

        public UserRepository(ICSVStream<User> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public System.Collections.Generic.IEnumerable<User> GetAllEager() => GetAll();

        public User GetEager(long id) => GetByID(id);

    }
}
