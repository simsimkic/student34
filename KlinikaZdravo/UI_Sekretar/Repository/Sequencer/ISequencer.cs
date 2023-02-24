// File:    ISequencer.cs
// Created: Monday, June 22, 2020 9:46:51 PM
// Purpose: Definition of Interface ISequencer

using System;

namespace ClassDiagram.Repository.Sequencer
{
   public interface ISequencer<T>
   {
      void Initialize(T initId);
      
      T GenerateId();
   
   }
}