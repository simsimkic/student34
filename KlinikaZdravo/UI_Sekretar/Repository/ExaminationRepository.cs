// File:    ExaminationRepository.cs
// Created: Monday, June 22, 2020 9:46:07 PM
// Purpose: Definition of Class ExaminationRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class ExaminationRepository : CSVRepository<Examination, long>,
        IExaminationRepository,
        IEagerCSVRepository<Examination, long>
    {
        private const string ENTITY_NAME = "Examination";

        public ExaminationRepository(ICSVStream<Examination> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }



        public IEnumerable<ExaminationRepository> FindAll(Func<ExaminationRepository, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Examination> GetAllEager() => GetAll();

        public Examination GetEager(long id) => GetByID(id);

        public IEnumerable<ExaminationRepository> GetScheduledExaminationForDoctorsInPeriod(Doctor doctor, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExaminationRepository> GetScheduledExaminationPeriod(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

    }
}