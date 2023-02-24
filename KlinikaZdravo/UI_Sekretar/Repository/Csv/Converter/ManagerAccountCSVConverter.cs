// File:    ManagerAccountCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:08 PM
// Purpose: Definition of Class ManagerAccountCSVConverter

using System;
using ClassDiagram.Model.Users;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class ManagerAccountCSVConverter : ICSVConverter<Manager>
    {
        private readonly string Delimiter;

        public ManagerAccountCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Manager ConvertCSVFormatToEntity(string managerAccountCSVFormat)
        {
            string[] tokens = managerAccountCSVFormat.Split(Delimiter.ToCharArray());
            return new Manager(long.Parse(tokens[0]));
        }

        public string ConvertEntityToCSVFormat(Manager manager)
            => string.Join(Delimiter,
                            manager.Id);
    }
}