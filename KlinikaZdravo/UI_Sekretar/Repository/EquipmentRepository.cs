// File:    EquipmentRepository.cs
// Created: Monday, June 22, 2020 9:46:06 PM
// Purpose: Definition of Class EquipmentRepository

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Rooms;
using ClassDiagram.Repository;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;

namespace ClassDiagram.Repository
{
    public class EquipmentRepository : CSVRepository<Equipment, long>,
        IEquipmentRepository,
        IEagerCSVRepository<Equipment, long>
    {
        private const string ENTITY_NAME = "Equipment";

        public EquipmentRepository(ICSVStream<Equipment> stream, ISequencer<long> sequencer)
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public Equipment AddEquipment(Equipment equipmentType)
        {
            throw new NotImplementedException();
        }

        
        public IEnumerable<Equipment> GetAllEager()
        {
            throw new NotImplementedException();
        }
        public Equipment GetEager(long id)
        {
            throw new NotImplementedException();
        }

        
        EquipmentRepository IEquipmentRepository.AddEquipment(Equipment equipmentType)
        {
            throw new NotImplementedException();
        }
    }
}