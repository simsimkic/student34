using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository
{
    public class VaccineRepository : CSVRepository<Vaccine, long>,
        IVaccineRepository,
        IEagerCSVRepository<Vaccine, long>
    {
        private const string ENTITY_NAME = "Vaccine";

    public VaccineRepository(ICSVStream<Vaccine> stream, ISequencer<long> sequencer)
        : base(ENTITY_NAME, stream, sequencer) { }

    public IEnumerable<Vaccine> GetAllEager() => GetAll();

    public Vaccine GetEager(long id) => GetByID(id);
}
}
