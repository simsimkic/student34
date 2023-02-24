// File:    Farmacy.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class Farmacy

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Medicine
{
    public class Farmacy : IIdentifiable<long>
    {
        public long Id { get; set; }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}