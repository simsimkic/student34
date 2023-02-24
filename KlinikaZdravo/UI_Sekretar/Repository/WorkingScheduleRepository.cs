// File:    WorkingScheduleRepository.cs
// Created: Monday, June 22, 2020 9:46:13 PM
// Purpose: Definition of Class WorkingScheduleRepository

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
    public class WorkingScheduleRepository : CSVRepository<WorkingHoursSchedule, long>,
         IWorkingScheduleRepository,
         IEagerCSVRepository<WorkingHoursSchedule, long>
    {
        private const string ENTITY_NAME = "WorkingHoursSchedule";

        public WorkingScheduleRepository(ICSVStream<WorkingHoursSchedule> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }

        public IEnumerable<WorkingHoursSchedule> GetAllEager()
        {
            throw new NotImplementedException();
        }

        public WorkingHoursSchedule GetEager(long id)
        {
            throw new NotImplementedException();
        }

        public WorkingHoursSchedule GetWorkingScheduleForDay(Days day)
        {
            throw new NotImplementedException();
        }

        public WorkingHoursSchedule GetWorkingScheduleForDoctor(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public WorkingHoursSchedule GetWorkingScheduleForDoctorInPeriod(DateTime startDate, DateTime endDate, Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}