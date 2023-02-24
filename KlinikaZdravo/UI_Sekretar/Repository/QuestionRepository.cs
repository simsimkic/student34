// File:    QuestionRepository.cs
// Created: Monday, June 22, 2020 9:46:10 PM
// Purpose: Definition of Class QuestionRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class QuestionRepository : CSVRepository<QuestionAndAnswer, long>,
         IQuestionRepository,
         IEagerCSVRepository<QuestionAndAnswer, long>
    {
        private const string ENTITY_NAME = "QuestionAndAnswer";

        public QuestionRepository(ICSVStream<QuestionAndAnswer> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }

        public IEnumerable<QuestionAndAnswer> GetAllEager() => GetAll();
        public QuestionAndAnswer GetEager(long id) => GetByID(id);
    }
}