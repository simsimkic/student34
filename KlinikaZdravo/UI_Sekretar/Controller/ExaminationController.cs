// File:    ExaminationController.cs
// Created: Tuesday, June 23, 2020 5:50:45 PM
// Purpose: Definition of Class ExaminationController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.ExaminationService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
    public class ExaminationController : IController<Examination, long>
    {
        private static ExaminationController Instance;
        private readonly IService<Examination, long> Service;
        public ExaminationController ExaminationControllerB;
        public ExaminationService ExaminationService;

        public ExaminationController(IService<Examination, long> service)
        {
            Service = service;
        }
        public static ExaminationController GetInstance(IService<Examination, long> service)
        {
            if (Instance == null)
            {
                Instance = new ExaminationController(service);
            }
            return Instance;
        }


        public IEnumerable<Examination> GetAll() => Service.GetAll();

        public Examination GetByID(long id) => Service.Get(id);

        public Examination Create(Examination entity) => Service.Create(entity);

        public void Update(Examination entity) => Service.Update(entity);

        public void Delete(Examination entity) => Service.Delete(entity);
        public Examination ScheduleExamination(Room room, Patient patient, Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Examination ScheduleWithRecommend(Priority priority, Patient patient, Doctor doctor)
        {
            throw new NotImplementedException();
        }


         public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long v) => Service.DeleteById(v);
    }
}