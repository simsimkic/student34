// File:    ExaminationService.cs
// Created: Thursday, May 28, 2020 4:02:06 PM
// Purpose: Definition of Class ExaminationService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.ExaminationService
{
    public class ExaminationService : IService<Examination, long>
    {
        private readonly IExaminationRepository Repository;
        public ExaminationService(IExaminationRepository repository)
        {
            Repository = repository;
        }
        public Examination Create(Examination entity) => Repository.Create(entity);

        public void Delete(Examination entity) => Repository.Delete(entity);

        public Examination Get(long id) => Repository.GetByID(id);
        public Examination CancelExamination(Examination examination)
        {
            throw new NotImplementedException();
        }

        public Examination ScheduleExamination(Room room, Patient patient, Doctor doctor)
        {
            throw new NotImplementedException();
        }
        public Examination ChangeExamination(Room room, Patient patient, Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Examination ScheduleWithRecommend(DateTime startDate, DateTime endDate, Priority priority)
        {
            throw new NotImplementedException();
        }

        public Examination GetAvailableExamination(Doctor doctor, DateTime startDate, DateTime endDate, Priority priority)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Examination> GetAll() => Repository.GetAll();


        public void Update(Examination entity) => Repository.Update(entity);

        public void DeleteById(long id) => Repository.DeleteById(id);
    }
}