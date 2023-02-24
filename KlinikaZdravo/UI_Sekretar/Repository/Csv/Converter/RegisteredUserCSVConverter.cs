using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    class RegisteredUserCSVConverter : ICSVConverter<RegisteredUser>
    {
        private readonly string Delimiter;
        public RegisteredUserCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public RegisteredUser ConvertCSVFormatToEntity(string registeredUserCSVFormat)
        {
            string[] tokens = registeredUserCSVFormat.Split(Delimiter.ToCharArray());
            List<Notifications> notifications = new List<Notifications>();
            ListCSVConverter.convertToLongList(tokens[3]).ForEach(id => notifications.Add(new Notifications(id)));
            return new RegisteredUser(long.Parse(tokens[0]),
                                      tokens[1],
                                      tokens[2],
                                      notifications);
        }

        public string ConvertEntityToCSVFormat(RegisteredUser registeredUser)
            => string.Join(Delimiter,
                           registeredUser.Id,
                           registeredUser.Username,
                           registeredUser.Password,
                           ListCSVConverter.convertToCSVFormat(registeredUser.Notifications));
    }
}
