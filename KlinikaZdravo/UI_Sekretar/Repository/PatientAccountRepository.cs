// File:    PatientAccountRepository.cs
// Created: Monday, June 22, 2020 9:46:09 PM
// Purpose: Definition of Class PatientAccountRepository

using System;
using System.Collections.Generic;
using System.Linq;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;
using KlinikaZdravo.Exception;

namespace ClassDiagram.Repository
{
    public class PatientAccountRepository : CSVRepository<Patient, long>,
         IPatientAccountRepository,
         IEagerCSVRepository<Patient, long>
    {
        private CSVStream<Patient> cSVStream;
        private LongSequencer longSequencer;

        public PatientAccountRepository(ICSVStream<Patient> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }

        private const string ENTITY_NAME = "Patient";
        private const string NOT_UNIQUE_ERROR = "Patient personal {0} is not unique!";

  

        public IEnumerable<Patient> GetAllEager() => GetAll();

        public Patient GetEager(long id) => GetByID(id);

        public void savePatient(Patient patient) => Create(patient);
     
        /*private Patient FindPatientByPersonalId(string personalId)
        {
            List<Patient> patients = Stream.ReadAll().ToList();
            return patients.SingleOrDefault(patient => patient.PersonalId.CompareTo(personalId) ==0);
        }

        private bool ExistsByPersonalId(string personalId)
            => FindPatientByPersonalId(personalId) == null ? false : true;
        */
        public Patient Create(Patient patient)
        {
            return base.Create(patient);
        }
    }
}