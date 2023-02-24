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
    public class PrescriptionRepository : CSVRepository<Prescription, long>,
        IPrescriptionRepository,
        IEagerCSVRepository<Prescription, long>
    {
        private const string ENTITY_NAME = "Allergie";

        public PrescriptionRepository(ICSVStream<Prescription> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer) { }

        public IEnumerable<Prescription> GetAllEager() => GetAll();

        public Prescription GetEager(long id) => GetByID(id);
    }
}
