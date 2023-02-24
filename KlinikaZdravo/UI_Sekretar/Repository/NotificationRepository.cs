// File:    NotificationRepository.cs
// Created: Monday, June 22, 2020 9:46:09 PM
// Purpose: Definition of Class NotificationRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class NotificationRepository : CSVRepository<Notifications, long>,
         INotificationRepository,
         IEagerCSVRepository<Notifications, long>
    {
        private const string ENTITY_NAME = "Notification";

        public NotificationRepository(ICSVStream<Notifications> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<Notifications> GetAllEager() => GetAll();

        public Notifications GetEager(long id) => GetByID(id);
    }
}