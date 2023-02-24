using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    public class CountryCSVConverter : ICSVConverter<Country>
    {
        private readonly string Delimiter;
        public CountryCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public Country ConvertCSVFormatToEntity(string countryCSVFormat)
        {
            string[] tokens = countryCSVFormat.Split(Delimiter.ToCharArray());
            return new Country(long.Parse(tokens[0]),
                                tokens[1]);
        }

        public string ConvertEntityToCSVFormat(Country country)
            => string.Join(Delimiter,
                           country.Id,
                           country.Name);
    }
}
