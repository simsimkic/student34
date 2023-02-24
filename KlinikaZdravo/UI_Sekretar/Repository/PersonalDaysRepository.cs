// File:    PersonalDaysRepository.cs
// Created: Monday, June 22, 2020 9:46:10 PM
// Purpose: Definition of Class PersonalDaysRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Model.WorkingSchedule;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class PersonalDaysRepository : CSVRepository<PersonalDay, long>,
         IPersonalDaysRepository,
         IEagerCSVRepository<PersonalDay, long>
    {
        private const string ENTITY_NAME = "PersonalDay";

        public PersonalDaysRepository(ICSVStream<PersonalDay> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }

        public IEnumerable<PersonalDay> GetAllEager() => GetAll();

        public PersonalDay GetEager(long id) => GetByID(id);

        public void savePersonalDay(PersonalDay personalDay) => Create(personalDay);

        public PersonalDaysRepository GetPersonalDay(Employee employeeId)
        {
            throw new NotImplementedException();
        }

        public PersonalDaysRepository SetPersonalDay(Employee employeeId, Days day)
        {
            throw new NotImplementedException();
        }
    }
}