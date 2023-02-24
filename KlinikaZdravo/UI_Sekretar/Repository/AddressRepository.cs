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
    public class AddressRepository : CSVRepository<Adress, long>,
        IAddressRepository,
        IEagerCSVRepository<Adress, long>
    {
        private const string ENTITY_NAME = "Address";

        public AddressRepository(ICSVStream<Adress> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer){ }

        public IEnumerable<Adress> GetAllEager() => GetAll();
        public Adress GetEager(long id) => GetByID(id);

        public Adress Create(Adress adress)
        {
            return base.Create(adress);
        }
    }
}
