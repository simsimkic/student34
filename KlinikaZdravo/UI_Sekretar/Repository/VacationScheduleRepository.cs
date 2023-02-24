// File:    VacationScheduleRepository.cs
// Created: Monday, June 22, 2020 9:46:13 PM
// Purpose: Definition of Class VacationScheduleRepository

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
    public class VacationScheduleRepository : CSVRepository<VacationSchedule, long>,
         IVacationScheduleRepository,
         IEagerCSVRepository<VacationSchedule, long>
    {
        private const string ENTITY_NAME = "VacationSchedule";
        


        public VacationScheduleRepository(ICSVStream<VacationSchedule> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<VacationSchedule> GetAllEager()
        {
            throw new NotImplementedException();
        }

        public VacationSchedule GetEager(long id)
        {
            throw new NotImplementedException();
        }

        public VacationSchedule GetVacationSchedule(DateTime startDate, DateTime endDate, Employee employee)
        {
            throw new NotImplementedException();
        }

        public VacationSchedule SetVacationSchedule(Employee employeeId)
        {
            throw new NotImplementedException();
        }
    }
}