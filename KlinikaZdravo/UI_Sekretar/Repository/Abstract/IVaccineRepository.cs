using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Abstract
{
    public interface IVaccineRepository : IRepository<Vaccine,long>
    {
    }
}
