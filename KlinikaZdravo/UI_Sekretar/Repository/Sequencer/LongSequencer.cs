// File:    LongSequencer.cs
// Created: Monday, June 22, 2020 9:46:49 PM
// Purpose: Definition of Class LongSequencer

using System;

namespace ClassDiagram.Repository.Sequencer
{
   public class LongSequencer : ISequencer<long>
   {
      private long NextId;

        public long GenerateId() => ++NextId;

        public void Initialize(long initId) => NextId = initId;
    }
}