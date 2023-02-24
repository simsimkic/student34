using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    public class UserCSVConverter : ICSVConverter<User>
    {
        private readonly string Delimiter;
        public UserCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public User ConvertCSVFormatToEntity(string userCSVFormat)
        {
            string[] tokens = userCSVFormat.Split(Delimiter.ToCharArray());
            return new User(long.Parse(tokens[0]),
                            tokens[1],
                            tokens[2],
                            DateTime.Parse(tokens[3]),
                            tokens[4],
                            bool.Parse(tokens[5]),
                            new Adress(long.Parse(tokens[6])),
                            new Contact(long.Parse(tokens[7])));
        }

        public string ConvertEntityToCSVFormat(User user)
            => string.Join(Delimiter,
                           user.Id,
                           user.Name,
                           user.Surname,
                           user.DateOfBirth,
                           user.PersonalId,
                           user.IsTemporaryAccount,
                           user.Adress.Id,
                           user.Contact.Id);
    }
}
