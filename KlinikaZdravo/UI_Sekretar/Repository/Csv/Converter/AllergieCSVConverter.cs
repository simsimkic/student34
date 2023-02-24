using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    public class AllergieCSVConverter:ICSVConverter<Allergie>
    {
        private readonly string Delimiter;
        public AllergieCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Allergie ConvertCSVFormatToEntity(string blogCSVFormat)
        {
            string[] tokens = blogCSVFormat.Split(Delimiter.ToCharArray());
            return new Allergie(
                   long.Parse(tokens[0]),
                   tokens[1]);
        }

        public string ConvertEntityToCSVFormat(Allergie allergie)
         => string.Join(Delimiter,
                           allergie.Id,
                           allergie.AllergyName);
    }
}
