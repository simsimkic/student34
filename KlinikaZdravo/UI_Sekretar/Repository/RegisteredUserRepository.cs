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
    class RegisteredUserRepository : CSVRepository<RegisteredUser, long>,
         IRegisteredUserRepository,
         IEagerCSVRepository<RegisteredUser, long>
    {
        private const string ENTITY_NAME = "RegisteredUser";

    public RegisteredUserRepository(ICSVStream<RegisteredUser> stream, ISequencer<long> sequencer)
        : base(ENTITY_NAME, stream, sequencer)
    {
    }
    public IEnumerable<RegisteredUser> GetAllEager() => GetAll();

    public RegisteredUser GetEager(long id) => GetByID(id);

    }
}
