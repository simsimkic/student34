// File:    PatientAccountCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:07 PM
// Purpose: Definition of Class PatientAccountCSVConverter

using System;
using System.Linq;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Users;
using iTextSharp.text;
using KlinikaZdravo.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class PatientAccountCSVConverter : ICSVConverter<Patient>
    {
        private readonly string Delimiter;

        public PatientAccountCSVConverter()
        {
        }
        public PatientAccountCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Patient ConvertCSVFormatToEntity(string patientCSVFormat)
        {
            string[] tokens = patientCSVFormat.Split(Delimiter.ToCharArray());
            List<Examination> examinations = new List<Examination>();

            ListCSVConverter.convertToLongList(tokens[1]).ForEach(id=>examinations.Add(new Examination(id)));
            return new Patient(long.Parse(tokens[0]),
                               long.Parse(tokens[1]),
                               examinations);
        }

        public string ConvertEntityToCSVFormat(Patient patient)
            => string.Join(Delimiter,
                           patient.Id,
                           patient.MedicalRecordId,
                           ListCSVConverter.convertToCSVFormat(patient.Examinations));
    }
}
