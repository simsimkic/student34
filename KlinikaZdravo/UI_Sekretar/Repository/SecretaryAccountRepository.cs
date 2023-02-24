// File:    SecretaryAccountRepository.cs
// Created: Monday, June 22, 2020 9:46:12 PM
// Purpose: Definition of Class SecretaryAccountRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class SecretaryAccountRepository : CSVRepository<Secretary, long>,
         ISecretaryAccountRepository,
         IEagerCSVRepository<Secretary, long>
    {
        private const string ENTITY_NAME = "Secretary";

        public SecretaryAccountRepository(ICSVStream<Secretary> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<Secretary> GetAllEager() => GetAll();

        public Secretary GetEager(long id) => GetByID(id);
    }
}