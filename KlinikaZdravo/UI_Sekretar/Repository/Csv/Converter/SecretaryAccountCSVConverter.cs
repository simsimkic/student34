// File:    SecretaryAccountCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:08 PM
// Purpose: Definition of Class SecretaryAccountCSVConverter

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Model.WorkingSchedule;
using KlinikaZdravo.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class SecretaryAccountCSVConverter : ICSVConverter<Secretary>
    {
        private readonly string Delimiter;
        public SecretaryAccountCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Secretary ConvertCSVFormatToEntity(string secretaryCSVFormat)
        {
            string[] tokens = secretaryCSVFormat.Split(Delimiter.ToCharArray());
            List<VacationSchedule> vacationSchedules = new List<VacationSchedule>();
            ListCSVConverter.convertToLongList(tokens[1]).ForEach(id => vacationSchedules.Add(new VacationSchedule(id)));
            return new Secretary(long.Parse(tokens[0]),
                                 vacationSchedules);
        }

        public string ConvertEntityToCSVFormat(Secretary secretary)
            => string.Join(Delimiter,
                           secretary.Id,
                           ListCSVConverter.convertToCSVFormat(secretary.VacationSchedules));
    }
}