// File:    IRefferalLetterRepository.cs
// Created: Monday, June 22, 2020 9:25:30 PM
// Purpose: Definition of Interface IRefferalLetterRepository

using System;
using ClassDiagram.Model.DoctorExaminations;

namespace ClassDiagram.Repository.Abstract
{
    public interface IRefferalLetterRepository : IRepository<ReferralLetter, long>
    {
    }
}