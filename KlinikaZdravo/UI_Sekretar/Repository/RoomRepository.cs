// File:    RoomRepository.cs
// Created: Monday, June 22, 2020 9:46:12 PM
// Purpose: Definition of Class RoomRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class RoomRepository : CSVRepository<Room, long>,
         IRoomRepository,
         IEagerCSVRepository<Room, long>
    {
        private const string ENTITY_NAME = "Room";

        public RoomRepository(ICSVStream<Room> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<Room> GetAllEager()
        {
            throw new NotImplementedException();
        }

        public Room GetEager(long id)
        {
            throw new NotImplementedException();
        }

        public Bed SetBedInfo(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}