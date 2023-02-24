// File:    NotificationCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:09 PM
// Purpose: Definition of Class NotificationCSVConverter

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using iTextSharp.text;
using KlinikaZdravo.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class NotificationCSVConverter : ICSVConverter<Notifications>
    {
        private readonly string Delimiter;
        public NotificationCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public Notifications ConvertCSVFormatToEntity(string notificationsCSVFormat)
        {
            string[] tokens = notificationsCSVFormat.Split(Delimiter.ToCharArray());
            List<RegisteredUser> registeredUsers = new List<RegisteredUser>();
            ListCSVConverter.convertToLongList(tokens[3]).ForEach(id => registeredUsers.Add(new RegisteredUser(id)));
            return new Notifications(long.Parse(tokens[0]),
                                      tokens[1],
                                      tokens[2],
                                      long.Parse(tokens[3]));
        }

        public string ConvertEntityToCSVFormat(Notifications notifications)
            => string.Join(Delimiter,
                           notifications.Id,
                           notifications.Messages,
                           notifications.Content,
                           notifications.RegisteredUsers);
    }
}