// File:    WorkingDay.cs
// Created: Monday, May 18, 2020 1:02:19 AM
// Purpose: Definition of Class WorkingDay

using System;

namespace ClassDiagram.Model.WorkingSchedule
{
   public class WorkingDay
   {
        public  DateTime From { get; set; }
        public  DateTime To { get; set; }


        public WorkingDay() { }
        public WorkingDay(DateTime from,DateTime to)
        {
            From = from;
            To = to;
        }

    }
}