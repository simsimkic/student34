// File:    RenovationCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:14 PM
// Purpose: Definition of Class RenovationCSVConverter

using System;
using ClassDiagram.Model.Rooms;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class RenovationCSVConverter : ICSVConverter<Renovation>
    {
        private readonly string Delimiter;
        public RenovationCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Renovation ConvertCSVFormatToEntity(string renovationCSVFormat)
        {
            string[] tokens = renovationCSVFormat.Split(Delimiter.ToCharArray());
            return new Renovation(long.Parse(tokens[0]),
               DateTime.Parse(tokens[1]),DateTime.Parse(tokens[2]),long.Parse(tokens[3]));
        }

        public string ConvertEntityToCSVFormat(Renovation renovation)
         => string.Join(Delimiter,
                           renovation.Id,
                           renovation.FromDate,
                           renovation.ToDate,
                           renovation.IdRoom);
    }
}