using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv.Converter;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Csv.Converter
{
    public class EmployeeCSVConverter : ICSVConverter<Employee>
    {
        private readonly string Delimiter;
        public EmployeeCSVConverter(string delimiter)
        {
            Delimiter = delimiter;
        }

        public Employee ConvertCSVFormatToEntity(string employeeCSVFormat)
        {
            string[] tokens = employeeCSVFormat.Split(Delimiter.ToCharArray());
            return new Employee(long.Parse(tokens[0]), tokens[1], tokens[2], DateTime.Parse(tokens[3]), tokens[4]/*,new Contact(long.Parse(tokens[5]))*/, tokens[5]);
        }

        public string ConvertEntityToCSVFormat(Employee employee)
            => string.Join(Delimiter,
                           employee.Id,
                           employee.Name,
                           employee.Surname,
                           employee.DateOfBirth,
                           employee.PersonalId,
                           //employee.Contact.Id,
                           employee.Employment);

    }
}
