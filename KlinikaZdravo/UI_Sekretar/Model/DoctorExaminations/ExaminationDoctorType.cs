using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Model.DoctorExaminations
{

    public class ExaminationDoctorType 
    {
      

    public Doctor Doctor { get; set; }
    public AppointmentType Type { get; set; }

    public ExaminationDoctorType() { }

    public ExaminationDoctorType( Doctor doctor, AppointmentType type)
    {
        
        Doctor = doctor;
        Type = type;
    }
}
}
