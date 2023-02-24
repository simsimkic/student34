using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;
using KlinikaZdravo.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository
{
    public class EmployeeRepository : CSVRepository<Employee, long>,
         IEmployeeRepository,
         IEagerCSVRepository<Employee, long>
    {
        private const string ENTITY_NAME = "Patient";

        public EmployeeRepository(ICSVStream<Employee> stream, ISequencer<long> sequencer)
        : base(ENTITY_NAME, stream, sequencer) { }

        public IEnumerable<Employee> GetAllEager() => GetAll();

        public Employee GetEager(long id) => GetByID(id);
    }
}
