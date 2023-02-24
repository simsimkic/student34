// File:    DrugCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:10 PM
// Purpose: Definition of Class DrugCSVConverter

using System;
using System.Threading;
using ClassDiagram.Model.Medicine;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class DrugCSVConverter : ICSVConverter<Drug>
    {
        private readonly string Delimiter;
        public DrugCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Drug ConvertCSVFormatToEntity(string drugCSVFormat)
        {
            string[] tokens = drugCSVFormat.Split(Delimiter.ToCharArray());
            return new Drug(long.Parse(tokens[0]),
                tokens[1]);
                
        }

        public string ConvertEntityToCSVFormat(Drug drug)
         => string.Join(Delimiter,
                           drug.Id,
                           drug.Name
                           );
    }
}