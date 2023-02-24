using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    public class VaccineCSVConverter:ICSVConverter<Vaccine>
    {
        private readonly string Delimiter;
        public VaccineCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Vaccine ConvertCSVFormatToEntity(string blogCSVFormat)
        {
            string[] tokens = blogCSVFormat.Split(Delimiter.ToCharArray());
            return new Vaccine(
                   long.Parse(tokens[0]),
                   DateTime.Parse(tokens[1]),
                   tokens[2]);
        }

        public string ConvertEntityToCSVFormat(Vaccine vaccine)
         => string.Join(Delimiter,
                           vaccine.Id,
                           vaccine.DateOfReceiving,
                           vaccine.VaccineName);

    }
    
    
}
