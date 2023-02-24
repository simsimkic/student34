// File:    RefferalToHospitalTreatmentCSVConverter.cs
// Created: Monday, June 22, 2020 9:19:55 PM
// Purpose: Definition of Class RefferalToHospitalTreatmentCSVConverter

using System;
using ClassDiagram.Model.DoctorExaminations;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class RefferalToHospitalTreatmentCSVConverter : ICSVConverter<Refferal>
    {
        public Refferal ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Refferal entity)
        {
            throw new NotImplementedException();
        }
    }
}