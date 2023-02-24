// File:    MedicalRecordCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:13 PM
// Purpose: Definition of Class MedicalRecordCSVConverter

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using KlinikaZdravo.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class MedicalRecordCSVConverter : ICSVConverter<MedicalRecord>
    {
        private readonly string Delimiter;
        public MedicalRecordCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public MedicalRecord ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            Console.WriteLine(entityCSVFormat);
            string[] tokens = entityCSVFormat.Split(Delimiter.ToCharArray());
            List<Allergie> allergies = new List<Allergie>();
            List<Vaccine> vaccines = new List<Vaccine>();
            List<Prescription> prescriptions = new List<Prescription>();
            ListCSVConverter.convertToLongList(tokens[1]).ForEach(id => allergies.Add(new Allergie(id)));
            ListCSVConverter.convertToLongList(tokens[2]).ForEach(id => vaccines.Add(new Vaccine(id)));
            ListCSVConverter.convertToLongList(tokens[3]).ForEach(id => prescriptions.Add(new Prescription(id)));
            return new MedicalRecord(long.Parse(tokens[0]),
                                      allergies,
                                      vaccines,
                                      prescriptions);
        }

        public string ConvertEntityToCSVFormat(MedicalRecord entity)
            => string.Join(Delimiter,
                           entity.Id,
                          ListCSVConverter.convertToCSVFormat(entity.AllergieCollection),
                          ListCSVConverter.convertToCSVFormat(entity.VaccineCollection),
                          ListCSVConverter.convertToCSVFormat(entity.PrescriptionCollection));
                           
    }
}