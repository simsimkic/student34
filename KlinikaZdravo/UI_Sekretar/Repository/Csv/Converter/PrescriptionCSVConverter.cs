using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    public class PrescriptionCSVConverter : ICSVConverter<Prescription>
    {
        private readonly string Delimiter;

        public PrescriptionCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }
        public Prescription ConvertCSVFormatToEntity(string addressCSVFormat)
        {
            string[] tokens = addressCSVFormat.Split(Delimiter.ToCharArray());
            return new Prescription(long.Parse(tokens[0]),
                              tokens[1],
                              tokens[2]);
        }

        public string ConvertEntityToCSVFormat(Prescription prescription)
            => string.Join(Delimiter,
                           prescription.Id,
                           prescription.Drug,
                           prescription.Use);
    }
}
