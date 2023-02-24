// File:    RenovationRepository.cs
// Created: Monday, June 22, 2020 9:46:11 PM
// Purpose: Definition of Class RenovationRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class RenovationRepository : CSVRepository<Renovation, long>,
         IRenovationRepository,
         IEagerCSVRepository<Renovation, long>
    {
        private const string ENTITY_NAME = "Renovation";

        public RenovationRepository(ICSVStream<Renovation> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<Renovation> GetAllEager() => GetAll();

        public Renovation GetEager(long id) => GetByID(id);

        public RenovationRepository ScheduleRenovation(DateTime startDate, DateTime endDate, Room roomId)
        {
            throw new NotImplementedException();
        }
    }
}