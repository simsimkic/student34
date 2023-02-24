// File:    Examination.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Examination


using ClassDiagram.Model.Rooms;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using KlinikaZdravo.Model.DoctorExaminations;
using KlinikaZdravo.Model.Users;
using System;
using System.Collections.Generic;

namespace ClassDiagram.Model.DoctorExaminations
{
    public class Examination : IIdentifiable<long>
    {
        public long Id { get; set; }
        //public ExaminationTime ExaminationTime { get; set; }
        //public ExaminationDoctorType ExaminationDoctorType { get; set; }
        //public ExaminationPatient ExaminationPatient { get; set; }

        public long DoctorId { get; set; }
        public String DoctorName { get; set; }
        public DateTime AvailableDate { get; set; }

        public AppointmentType Type { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public List<Refferal> Refferals { get; set; }
        public long PatientId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Boolean IsScheduled { get; set; }
        public long RoomId { get; set; }
        public DateTime Vreme;
        public String Scheduled{ get
            {
                if (RoomId==0) return "SLOBODAN";
                return "ZAKAZAN";
            }
            set {
                if (RoomId == 0) { Scheduled = "SLOBODAN"; }
                else Scheduled = "ZAKAZAN";
            }
        }
        public Examination()
        {
        }
        public Examination(long id)
        {
            Id = id;
        }
    /*    public Examination(long id, long doctorId, String doctorName, AppointmentType type, DateTime fromDate, DateTime toDate, long roomId)
        {
            Id = id;
            DoctorId= doctorId;
            IsScheduled = false;
            Type = type;
            FromDate = fromDate;
            ToDate = toDate;
            RoomId = roomId;

        }*/
        public Examination(long id, String doctorName,  DateTime availableDate, DateTime vreme, long roomId)
        {
            Id = id;
            DoctorName = doctorName; 
            AvailableDate = availableDate;
            Vreme = vreme;
            RoomId = roomId;
            Type = AppointmentType.regularExamination;

        }




        // public Examination(long id, ExaminationTime examinationTime,
        //    ExaminationDoctorType examinationDoctorType,ExaminationPatient examinationPatient)
        //{
        //    Id = id;
        //    ExaminationTime = examinationTime;
        //    ExaminationDoctorType = examinationDoctorType;
        //    ExaminationPatient = examinationPatient;
        //}

        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}