// File:    ReportCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:15 PM
// Purpose: Definition of Class ReportCSVConverter

using System;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class ReportCSVConverter : ICSVConverter<Report>
    {
        private readonly string Delimiter;
        public ReportCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Report ConvertCSVFormatToEntity(string reportCSVFormat)
        {
            string[] tokens = reportCSVFormat.Split(Delimiter.ToCharArray());
            return new Report(long.Parse(tokens[0]),
                              tokens[1]);
        }

        public string ConvertEntityToCSVFormat(Report report)
            => string.Join(Delimiter,
                            report.Id,
                            report.Content);
    }
}