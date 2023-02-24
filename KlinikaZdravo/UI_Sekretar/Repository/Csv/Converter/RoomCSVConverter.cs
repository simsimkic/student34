// File:    RoomCSVConverter.cs
// Created: Monday, June 22, 2020 9:09:17 PM
// Purpose: Definition of Class RoomCSVConverter

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Rooms;
using KlinikaZdravo.Repository.Csv.Converter;

namespace ClassDiagram.Repository.Csv.Converter
{
    public class RoomCSVConverter : ICSVConverter<Room>
    {
        private readonly string Delimiter;
        public RoomCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Room ConvertCSVFormatToEntity(string roomCSVFormat)
        {
            string[] tokens = roomCSVFormat.Split(Delimiter.ToCharArray());
            List<Inventory> inventory = new List<Inventory>();
            List<Renovation> renovation = new List<Renovation>();
            return new Room(
                   long.Parse(tokens[0]),
                   int.Parse(tokens[1]),
                     inventory, renovation
                   );
        }

        public string ConvertEntityToCSVFormat(Room room)
            => string.Join(Delimiter,
                           room.Id,
                           room.Floor,
                           ListCSVConverter.convertToCSVFormat(room.Inventory),
                            ListCSVConverter.convertToCSVFormat(room.Renovation));
    
    }
}