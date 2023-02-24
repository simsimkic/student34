// File:    DoctorSpecialist.cs
// Created: Saturday, May 30, 2020 2:46:57 PM
// Purpose: Definition of Class DoctorSpecialist

using System;
using ClassDiagram.Repository.Abstract;

namespace ClassDiagram.Model.Users
{
   public class DoctorSpecialist : Doctor, IIdentifiable<long>
    {
      private Specialization specialization;
   
   }
}