// File:    DrugRepository.cs
// Created: Monday, June 22, 2020 9:46:06 PM
// Purpose: Definition of Class DrugRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Medicine;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class DrugRepository : CSVRepository<Drug, long>,
         IDrugRepository,
         IEagerCSVRepository<Drug, long>
    {
        private const string ENTITY_NAME = "Drug";

        public DrugRepository(ICSVStream<Drug> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<Drug> GetAllEager() => GetAll();

        public Drug GetEager(long id) => GetByID(id);
    }
}