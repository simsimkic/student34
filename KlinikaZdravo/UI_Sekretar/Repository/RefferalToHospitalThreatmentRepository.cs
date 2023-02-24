// File:    RefferalToHospitalThreatmentRepository.cs
// Created: Monday, June 22, 2020 9:46:11 PM
// Purpose: Definition of Class RefferalToHospitalThreatmentRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class RefferalToHospitalThreatmentRepository : CSVRepository<Refferal, long>,
         IRefferalToHospitalTreatmentRepository,
         IEagerCSVRepository<Refferal, long>
    {
        private const string ENTITY_NAME = "Refferal";

        public RefferalToHospitalThreatmentRepository(ICSVStream<Refferal> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<Refferal> GetAllEager()
        {
            throw new NotImplementedException();
        }

        public Refferal GetEager(long id)
        {
            throw new NotImplementedException();
        }
    }
}