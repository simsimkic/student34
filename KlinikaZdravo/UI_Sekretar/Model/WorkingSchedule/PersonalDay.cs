// File:    PersonalDay.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class PersonalDay

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.WorkingSchedule
{
   public class PersonalDay : IIdentifiable<long>
    {
        public long Id { get; set; }
        public Days Day;
        public string Name { get; set; }
        public PersonalDay() { }
        public PersonalDay(long id)
        {
            Id = id;
        }
        public PersonalDay(long id,string name, Days day)
        {
            Id = id;
            Name = name;

            Day = day;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}