// File:    MedicalRecordRepository.cs
// Created: Monday, June 22, 2020 9:46:08 PM
// Purpose: Definition of Class MedicalRecordRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class MedicalRecordRepository : CSVRepository<MedicalRecord, long>,
         IMedicalRecordRepository,
         IEagerCSVRepository<MedicalRecord, long>
    {
        private const string ENTITY_NAME = "MedicalRecord";

        public MedicalRecordRepository(ICSVStream<MedicalRecord> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<MedicalRecord> GetAllEager() => GetAll();

        public MedicalRecord GetEager(long id) => GetByID(id);
    }
}