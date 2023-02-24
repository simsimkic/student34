// File:    ReportRepository.cs
// Created: Monday, June 22, 2020 9:46:12 PM
// Purpose: Definition of Class ReportRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class ReportRepository : CSVRepository<Report, long>,
         IReportRepository,
         IEagerCSVRepository<Report, long>
    {
        private const string ENTITY_NAME = "Report";

        public ReportRepository(ICSVStream<Report> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public ReportRepository Create(ReportRepository entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ReportRepository entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReportRepository> FindAll(Func<ReportRepository, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Report> GetAllEager()
        {
            throw new NotImplementedException();
        }

        public Report GetEager(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(ReportRepository entity)
        {
            throw new NotImplementedException();
        }

       
    }
}