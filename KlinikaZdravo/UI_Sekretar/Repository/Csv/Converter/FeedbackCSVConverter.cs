// File:    FeedbackCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:11 PM
// Purpose: Definition of Class FeedbackCSVConverter

using System;
using ClassDiagram.Model.Users;
using KlinikaZdravo.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class FeedbackCSVConverter : ICSVConverter<Feedback>
    {
        private readonly string Delimiter;
        public FeedbackCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public Feedback ConvertCSVFormatToEntity(string feedbackCSVFormat)
        {
            string[] tokens = feedbackCSVFormat.Split(Delimiter.ToCharArray());
            return new Feedback(long.Parse(tokens[0]),
                                tokens[1]);
        }

        public string ConvertEntityToCSVFormat(Feedback feedback)
            => string.Join(Delimiter,
                           feedback.Id);
    }
}