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
    public class CountryRepository : CSVRepository<Country, long>,
         ICountryRepository,
         IEagerCSVRepository<Country, long>
    {
        private const string ENTITY_NAME = "Country";

        public CountryRepository(ICSVStream<Country> stream, ISequencer<long> sequencer)
        : base(ENTITY_NAME, stream, sequencer) { }

        public IEnumerable<Country> GetAllEager() => GetAll();

        public Country GetEager(long id) => GetByID(id);

    }
}
