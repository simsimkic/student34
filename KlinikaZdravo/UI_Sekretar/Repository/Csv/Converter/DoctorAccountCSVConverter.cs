// File:    DoctorAccountCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:09 PM
// Purpose: Definition of Class DoctorAccountCSVConverter

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Model.Users;
using KlinikaZdravo.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class DoctorAccountCSVConverter : ICSVConverter<Doctor>
    {
        private readonly string Delimiter;
        public DoctorAccountCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        Doctor ICSVConverter<Doctor>.ConvertCSVFormatToEntity(string doctorCSVFormat)
        {
            string[] tokens = doctorCSVFormat.Split(Delimiter.ToCharArray());
            List<Blog> blogs = new List<Blog>();
            ListCSVConverter.convertToLongList(tokens[1]).ForEach(id => blogs.Add(new Blog(id)));
            return new Doctor(long.Parse(tokens[0]),
                              blogs);
        }

        public string ConvertEntityToCSVFormat(Doctor doctor)
            => string.Join(Delimiter,
                           doctor.Id,
                           ListCSVConverter.convertToCSVFormat(doctor.Blogs));

       
    }
}