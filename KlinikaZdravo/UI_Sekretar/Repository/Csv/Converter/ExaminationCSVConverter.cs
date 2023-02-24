// File:    ExaminationCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:11 PM
// Purpose: Definition of Class ExaminationCSVConverter

using System;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Model.Users;
using KlinikaZdravo.Model.DoctorExaminations;
using KlinikaZdravo.Model.Users;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class ExaminationCSVConverter : ICSVConverter<Examination>
    {
        private readonly string Delimiter;
        public Examination ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(Delimiter.ToCharArray());
            return new Examination(
                   long.Parse(tokens[0]),
                   tokens[1],
                   DateTime.Parse(tokens[2]),
                   DateTime.Parse(tokens[3]),
                   long.Parse(tokens[4]));
        }

        public string ConvertEntityToCSVFormat(Examination examination)
        => string.Join(Delimiter,
                 examination.Id,
                 examination.DoctorName,
                 examination.AvailableDate,
                 examination.Vreme,
                 examination.RoomId);


        /*     public string ConvertEntityToCSVFormat(Examination patient)
             => string.Join(Delimiter,
                        patient.Id);
                        */
        /*
                public string ConvertEntityToCSVFormat(Examination examination)
            => string.Join(Delimiter,
                           examination.Id,
                           examination.DoctorId,
                           examination.Type,
                           examination.FromDate,
                           examination.ToDate,
                           examination.RoomId);
        */
        public ExaminationCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }


    }
}