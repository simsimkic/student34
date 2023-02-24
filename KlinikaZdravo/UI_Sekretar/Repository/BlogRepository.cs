// File:    BlogRepository.cs
// Created: Monday, June 22, 2020 9:46:04 PM
// Purpose: Definition of Class BlogRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Questions;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class BlogRepository : CSVRepository<Blog, long>,
         IBlogRepository,
         IEagerCSVRepository<Blog, long>
    {
        private CSVStream<Blog> cSVStream;
        private LongSequencer longSequencer;
        private const string ENTITY_NAME = "Blog";

        public BlogRepository(ICSVStream<Blog> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<Blog> GetAllEager() => GetAll();

        public Blog GetEager(long id) => GetByID(id);
    }
}