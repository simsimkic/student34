// File:    FeedbackRepository.cs
// Created: Monday, June 22, 2020 9:46:07 PM
// Purpose: Definition of Class FeedbackRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class FeedbackRepository : CSVRepository<Feedback, long>,
         IFeedbackRepository,
         IEagerCSVRepository<Feedback, long>
    {
        private const string ENTITY_NAME = "Feedback";

        public FeedbackRepository(ICSVStream<Feedback> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }

        public IEnumerable<Feedback> GetAllEager() => GetAll();

        public Feedback GetEager(long id) => GetByID(id);
    }
}