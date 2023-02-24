// File:    MenagerAccountRepository.cs
// Created: Monday, June 22, 2020 9:46:08 PM
// Purpose: Definition of Class MenagerAccountRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class MenagerAccountRepository : CSVRepository<Manager, long>,
         IManagerAccountRepository,
         IEagerCSVRepository<Manager, long>
    {
        private const string ENTITY_NAME = "Menager";

        public MenagerAccountRepository(ICSVStream<Manager> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<Manager> GetAllEager() => GetAll();

        public Manager GetEager(long id) => GetByID(id);
    }
}