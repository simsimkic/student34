// File:    DrugService.cs
// Created: Monday, May 25, 2020 3:26:43 AM
// Purpose: Definition of Class DrugService

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Medicine;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Service.ManagerService
{
   public class DrugService : IService<Drug, long>
    {
        private readonly IDrugRepository repository;

        private readonly IDrugRepository Repository;
        public DrugService(IDrugRepository repository)
        {
            Repository = repository;
        }
        public Drug AddNewDrug(String drugName, String doctorName)
      {
         throw new NotImplementedException();
      }
        public Drug Create(Drug entity) => Repository.Create(entity);

        public void Delete(Drug entity) => Repository.Delete(entity);

        public Drug Get(long id) => Repository.GetByID(id);

        public IEnumerable<Drug> GetAll() => Repository.GetAll();

        public void Update(Drug entity) => Repository.Update(entity);

        public Boolean DeleteDrug(Drug drugName)
      {
         throw new NotImplementedException();
      }
      
      public int BuyMoreDrugQuantity(int quantity)
      {
         throw new NotImplementedException();
      }

        public void DeleteById(long id) => Repository.DeleteById(id);
    }
}