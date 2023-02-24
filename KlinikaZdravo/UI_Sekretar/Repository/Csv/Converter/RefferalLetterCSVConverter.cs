// File:    RefferalLetterCSVConverter.cs
// Created: Monday, June 22, 2020 9:19:54 PM
// Purpose: Definition of Class RefferalLetterCSVConverter

using System;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class RefferalLetterCSVConverter : ICSVConverter<ReferralLetter>
    {
        private readonly string Delimiter;
        public RefferalLetterCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public ReferralLetter ConvertCSVFormatToEntity(string questionAndAnswerCSVFormat)
        {
            string[] tokens = questionAndAnswerCSVFormat.Split(Delimiter.ToCharArray());
            return new ReferralLetter(long.Parse(tokens[0]),
                                    (Specialization)Enum.Parse(typeof(Specialization), tokens[1]),
                                    DateTime.Parse(tokens[2]));
        }

        public string ConvertEntityToCSVFormat(ReferralLetter questionAndAnswer)
         => string.Join(Delimiter,
                           questionAndAnswer.Id,
                           questionAndAnswer.DoctorSpecialization,
                           questionAndAnswer.IssuingDate);
    }
}
