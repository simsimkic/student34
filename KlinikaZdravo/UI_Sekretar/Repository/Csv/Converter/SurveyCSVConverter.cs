// File:    SurveyCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:17 PM
// Purpose: Definition of Class SurveyCSVConverter

using System;
using ClassDiagram.Model.Questions;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class SurveyCSVConverter : ICSVConverter<Survey>
    {
        public Survey ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Survey entity)
        {
            throw new NotImplementedException();
        }
    }
}