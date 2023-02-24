// File:    DoctorAccountRepository.cs
// Created: Monday, June 22, 2020 9:46:05 PM
// Purpose: Definition of Class DoctorAccountRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class DoctorAccountRepository : CSVRepository<Doctor, long>,
         IDoctorAccountRepository,
         IEagerCSVRepository<Doctor, long>
    {
        private const string ENTITY_NAME = "Doctor";

        public DoctorAccountRepository(ICSVStream<Doctor> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public System.Collections.Generic.IEnumerable<Doctor> GetAllEager() => GetAll();

        public Doctor GetEager(long id) => GetByID(id);
    }
}