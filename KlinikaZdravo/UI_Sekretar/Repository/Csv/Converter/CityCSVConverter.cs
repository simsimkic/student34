using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    public class CityCSVConverter : ICSVConverter<City>
    {
        private readonly string Delimiter;

        public CityCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public City ConvertCSVFormatToEntity(string cityCSVFormat)
        {
            string[] tokens = cityCSVFormat.Split(Delimiter.ToCharArray());
            return new City(long.Parse(tokens[0]),
                        tokens[1]/*,
                        tokens[2],
                        new Country(long.Parse(tokens[3]))*/);
        }

        public string ConvertEntityToCSVFormat(City city)
            => string.Join(Delimiter,
                           city.Id,
                           city.Name/*,
                           city.PostalCode,
                           city.Country.Id*/);
    }
}
