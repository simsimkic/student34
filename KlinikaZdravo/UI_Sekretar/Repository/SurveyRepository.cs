// File:    SurveyRepository.cs
// Created: Monday, June 22, 2020 9:46:12 PM
// Purpose: Definition of Class SurveyRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class SurveyRepository : CSVRepository<Survey, long>,
         ISurveyRepository,
         IEagerCSVRepository<Survey, long>
    {
        private const string ENTITY_NAME = "Survey";

        public SurveyRepository(ICSVStream<Survey> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<Survey> GetAllEager() => GetAll();
        public Survey GetEager(long id) => GetByID(id);
    }
}