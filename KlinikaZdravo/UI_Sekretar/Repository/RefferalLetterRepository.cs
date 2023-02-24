// File:    RefferalLetterRepository.cs
// Created: Monday, June 22, 2020 9:46:11 PM
// Purpose: Definition of Class RefferalLetterRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class RefferalLetterRepository : CSVRepository<ReferralLetter, long>,
         IEagerCSVRepository<ReferralLetter, long>,
         IRefferalLetterRepository
    {
        private const string ENTITY_NAME = "ReferralLetter";

        public RefferalLetterRepository(ICSVStream<ReferralLetter> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public IEnumerable<ReferralLetter> GetAllEager()=>GetAll();
        

        public ReferralLetter GetEager(long id)
        {
            throw new NotImplementedException();
        }
    }
}