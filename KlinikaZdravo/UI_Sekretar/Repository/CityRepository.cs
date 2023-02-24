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
    public class CityRepository : CSVRepository<City, long>,
        ICityRepository,
        IEagerCSVRepository<City, long>
        {
        private const string ENTITY_NAME = "City";

        public CityRepository(ICSVStream<City> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }

        public IEnumerable<City> GetAllEager() => GetAll();

        public City GetEager(long id) => GetByID(id);
        public City Create(City city)
        {
            return base.Create(city);
        }
    }
}
