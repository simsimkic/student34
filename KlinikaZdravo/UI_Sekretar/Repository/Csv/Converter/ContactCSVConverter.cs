using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    public class ContactCSVConverter : ICSVConverter<Contact>
    {
        private readonly string Delimiter;
        public ContactCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Contact ConvertCSVFormatToEntity(string contactCSVFormat)
        {
            string[] tokens = contactCSVFormat.Split(Delimiter.ToCharArray());
            return new Contact(long.Parse(tokens[0]),
                                tokens[1],
                                tokens[2]);
        }

        public string ConvertEntityToCSVFormat(Contact contact)
            => string.Join(Delimiter,
                           contact.Id,
                           contact.PhoneNumber,
                           contact.EmailAdress);
    }
}
