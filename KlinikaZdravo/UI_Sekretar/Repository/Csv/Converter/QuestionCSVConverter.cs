// File:    QuestionCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:14 PM
// Purpose: Definition of Class QuestionCSVConverter

using System;
using ClassDiagram.Model.Questions;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class QuestionCSVConverter : ICSVConverter<QuestionAndAnswer>
    {
        private readonly string Delimiter;
        public QuestionCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public QuestionAndAnswer ConvertCSVFormatToEntity(string questionAndAnswerCSVFormat)
        {
            string[] tokens = questionAndAnswerCSVFormat.Split(Delimiter.ToCharArray());
            return new QuestionAndAnswer(long.Parse(tokens[0]),
                                tokens[1],
                                tokens[2],
                                new Doctor(long.Parse(tokens[3])),
                                new Patient(long.Parse(tokens[4])));
        }

        public string ConvertEntityToCSVFormat(QuestionAndAnswer questionAndAnswer)
         => string.Join(Delimiter,
                           questionAndAnswer.Id,
                           questionAndAnswer.Content,
                           questionAndAnswer.Subject,
                           questionAndAnswer.Doktor,
                           questionAndAnswer.Pacijent);
    }
}