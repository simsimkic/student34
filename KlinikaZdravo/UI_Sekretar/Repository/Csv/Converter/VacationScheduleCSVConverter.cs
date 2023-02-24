// File:    VacationScheduleCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:18 PM
// Purpose: Definition of Class VacationScheduleCSVConverter

using System;
using ClassDiagram.Model.WorkingSchedule;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class VacationScheduleCSVConverter : ICSVConverter<VacationSchedule>
    {
        private readonly string Delimiter;
        public VacationScheduleCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public VacationSchedule ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(Delimiter.ToCharArray());
            return new VacationSchedule(long.Parse(tokens[0]), tokens[1],
                DateTime.Parse(tokens[2]),
                DateTime.Parse(tokens[3]));
        }

        public string ConvertEntityToCSVFormat(VacationSchedule entity)
       => string.Join(Delimiter,
                           entity.Id,
                           entity.Name,
                          entity.From,
                          entity.To);
    }
}