using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    public class AddressCSVConverter : ICSVConverter<Adress>
    {
        private readonly string Delimiter;

        public AddressCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Adress ConvertCSVFormatToEntity(string addressCSVFormat)
        {
            string[] tokens = addressCSVFormat.Split(Delimiter.ToCharArray());
            return new Adress(long.Parse(tokens[0]),
                              tokens[1],
                              tokens[2],
                              new City(long.Parse(tokens[3])));
        }

        public string ConvertEntityToCSVFormat(Adress address)
            => string.Join(Delimiter,
                           address.Id,
                           address.Street,
                           address.Number,
                           address.City.Id);
    }
}
