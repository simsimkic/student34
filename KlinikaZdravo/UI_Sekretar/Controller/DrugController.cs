// File:    DrugController.cs
// Created: Tuesday, June 23, 2020 5:50:39 PM
// Purpose: Definition of Class DrugController

using System;
using System.Collections.Generic;
using ClassDiagram.Model.Medicine;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.ManagerService;
using ClassDiagram.Service.UserService;

namespace ClassDiagram.Controller
{
   public class DrugController : IController<Drug,long>
   {
        private static DrugController Instance;
        public DrugController DrugControllerB;
        public DrugService DrugService;
        private readonly IService<Drug, long> Service;
        public DrugController(IService<Drug, long> service)
        {
            Service = service;
        }
        public static DrugController GetInstance(IService<Drug, long> service)
        {
            if (Instance == null)
            {
                Instance = new DrugController(service);
            }
            return Instance;
        }
        public IEnumerable<Drug> GetAll() => Service.GetAll();

        public Drug GetByID(long id) => Service.Get(id);

        public Drug Create(Drug entity) => Service.Create(entity); 
        public void Update(Drug entity) => Service.Update(entity);

        public void Delete(Drug entity) => Service.Delete(entity);

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public DrugController GetInstance()
      {
         throw new NotImplementedException();
      }
      
      public Drug AddNewDrug(Drug drug, Doctor doctor)
      {
         throw new NotImplementedException();
      }
      
      public int ByMoreDrugQuantity(int quantity, Drug drug)
      {
         throw new NotImplementedException();
      }

        public void DeleteById(long v) => Service.DeleteById(v);
    }
}