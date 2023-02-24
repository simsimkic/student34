// File:    CSVStream.cs
// Created: Monday, June 22, 2020 9:27:45 PM
// Purpose: Definition of Class CSVStream

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClassDiagram.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Stream
{
   public class CSVStream<T> : ICSVStream<T> where T : class
   {

        private string Path;
        private ICSVConverter<T> Converter;

        public CSVStream(string path, ICSVConverter<T> converter)
        {
            Path = path;
            Converter = converter;
        }

        public void AppendToFile(T entity)
        => File.AppendAllText(Path, Converter.ConvertEntityToCSVFormat(entity) + Environment.NewLine);


        public IEnumerable<T> ReadAll()
        => File.ReadAllLines(Path).Select(Converter.ConvertCSVFormatToEntity).ToList();
       

        public void SaveAll(IEnumerable<T> entities)
        => WriteAllLinesToFile(entities.Select(Converter.ConvertEntityToCSVFormat).ToList());

        public void WriteAllLinesToFile(IEnumerable<string> content)
        => File.WriteAllLines(Path, content.ToArray());
    }
}