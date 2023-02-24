// File:    EquipmentCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:10 PM
// Purpose: Definition of Class EquipmentCSVConverter

using System;
using ClassDiagram.Model.Rooms;

namespace ClassDiagram.Repository.Csv.Converter
{

    public class EquipmentCSVConverter : ICSVConverter<Equipment>
    {
        private readonly string Delimiter;
        public EquipmentCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public Equipment ConvertCSVFormatToEntity(string equipmentCSVFormat)
        {
            string[] tokens = equipmentCSVFormat.Split(Delimiter.ToCharArray());
            return new Equipment(
                   long.Parse(tokens[0]),
                   tokens[1],
                   int.Parse(tokens[2]));
        }

        public string ConvertEntityToCSVFormat(Equipment equipment)
       => string.Join(Delimiter,
                           equipment.Id,
                           equipment.Name,
                           equipment.Quantity);

    }
}