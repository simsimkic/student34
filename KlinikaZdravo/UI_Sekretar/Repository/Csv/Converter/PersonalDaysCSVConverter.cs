// File:    PersonalDaysCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:13 PM
// Purpose: Definition of Class PersonalDaysCSVConverter

using System;
using ClassDiagram.Model.WorkingSchedule;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class PersonalDaysCSVConverter : ICSVConverter<PersonalDay>
    {

        private readonly string Delimiter;
        public PersonalDaysCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public PersonalDay ConvertCSVFormatToEntity(string personalDayCSVFormat)
        {
            string[] tokens = personalDayCSVFormat.Split(Delimiter.ToCharArray());
            return new PersonalDay(
                   long.Parse(tokens[0]),
                   tokens[1],
                   (Days)Enum.Parse(typeof(Days),tokens[2]));
        }

        public string ConvertEntityToCSVFormat(PersonalDay personalDay)
          => string.Join(Delimiter,
                           personalDay.Id,
                           personalDay.Name,
                           personalDay.Day.ToString());
    }
}