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
    class ContactRepository : CSVRepository<Contact, long>,
         IContactRepository,
         IEagerCSVRepository<Contact, long>
    {
        private const string ENTITY_NAME = "Contact";

        public ContactRepository(ICSVStream<Contact> stream, ISequencer<long> sequencer)
        : base(ENTITY_NAME, stream, sequencer) { }

        public IEnumerable<Contact> GetAllEager() => GetAll();

        public Contact GetEager(long id) => GetByID(id);

        public Contact Create(Contact contact)
        {
            return base.Create(contact);
        }

    }
}
