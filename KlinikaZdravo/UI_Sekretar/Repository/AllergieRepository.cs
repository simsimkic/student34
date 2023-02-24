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
    public class AllergieRepository: CSVRepository<Allergie, long>,
        IAllergieRepository,
        IEagerCSVRepository<Allergie, long>
    {
        private const string ENTITY_NAME = "Allergie";

    public AllergieRepository(ICSVStream<Allergie> stream, ISequencer<long> sequencer)
        : base(ENTITY_NAME, stream, sequencer) { }

    public IEnumerable<Allergie> GetAllEager() => GetAll();

    public Allergie GetEager(long id) => GetByID(id);
}
}
