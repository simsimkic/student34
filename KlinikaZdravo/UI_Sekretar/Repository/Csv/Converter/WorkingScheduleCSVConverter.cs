// File:    WorkingScheduleCSVConverter.cs
// Created: Monday, June 22, 2020 9:14:09 PM
// Purpose: Definition of Class WorkingScheduleCSVConverter

using System;
using System.Collections.Generic;
using ClassDiagram.Model.WorkingSchedule;
using KlinikaZdravo.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class WorkingScheduleCSVConverter : ICSVConverter<WorkingHoursSchedule>
    {
        private readonly string Delimiter;
        public WorkingScheduleCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public WorkingHoursSchedule ConvertCSVFormatToEntity(string workingScheduleCSVFormat)
        {
            string[] tokens = workingScheduleCSVFormat.Split(Delimiter.ToCharArray());
            List<WorkingDay> workingDays = new List<WorkingDay>();
            //ListCSVConverter.convertToLongList(tokens[2]).ForEach(id => workingDays.Add(new WorkingDay));
            return new WorkingHoursSchedule(long.Parse(tokens[0]),
                                tokens[1],
                               DateTime.Parse(tokens[2]),
                                DateTime.Parse(tokens[3])
                                //workingDays
                                );
        }

        public string ConvertEntityToCSVFormat(WorkingHoursSchedule workingHoursSchedule)
            => string.Join(Delimiter,
                           workingHoursSchedule.Id,
                           workingHoursSchedule.Name,
                           workingHoursSchedule.From,
                           workingHoursSchedule.To
                          // ListCSVConverter.convertToCSVFormat(workingHoursSchedule.WorkingDay)
                          );
    }
}