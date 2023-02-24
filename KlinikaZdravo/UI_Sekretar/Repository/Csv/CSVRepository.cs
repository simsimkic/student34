// File:    CSVRepository.cs
// Created: Monday, June 22, 2020 8:46:40 PM
// Purpose: Definition of Class CSVRepository

using System;
using System.Collections.Generic;
using System.Linq;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using ClassDiagram.Repository.Csv.Stream;
using ClassDiagram.Repository.Sequencer;
using KlinikaZdravo.Exception;

namespace ClassDiagram.Repository.Csv
{
   public class CSVRepository<T,ID> : IRepository<T, ID>
        where T : IIdentifiable<ID>
        where ID : IComparable
   {

      public String EntityName;
      public ICSVStream<T> Stream;
      public ISequencer<ID> Sequencer;

     private const string NOT_FOUND_ERROR = "{0} with {1}:{2} can not be found!";


        public CSVRepository(string entityName, ICSVStream<T> stream, ISequencer<ID> sequencer)
        {
            EntityName = entityName;
            Stream = stream;
            Sequencer = sequencer;
            InitializeId();
        }

        protected void InitializeId() => Sequencer.Initialize(GetMaxId(Stream.ReadAll()));

        private ID GetMaxId(IEnumerable<T> entities)
           => entities.Count() == 0 ? default : entities.Max(entity => entity.GetId());

        private void ThrowEntityNotFoundException(string key, object value)

          => throw new EntityNotFoundException(string.Format(null, EntityName, key, value));



        public T Create(T entity)
        {
            entity.SetId(Sequencer.GenerateId());
            Stream.AppendToFile(entity);
            return entity;
        }



        public void Delete(T entity)
        {
            var entities = Stream.ReadAll().ToList();
            var entityToRemove = entities.SingleOrDefault(ent => ent.GetId().CompareTo(entity.GetId()) == 0);
            if (entityToRemove != null)
            {
                entities.Remove(entityToRemove);
                Stream.SaveAll(entities);
            }
            else
            {
                ThrowEntityNotFoundException("id", entity.GetId());
            }
        }


        public void DeleteAll()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<T> FindAll(Func<T, bool> predicate) => Stream.ReadAll().Where(predicate);



        public T FindByID(ID id)
        {
            throw new NotImplementedException();


        }

        public IEnumerable<T> GetAll() => Stream.ReadAll();



        public T GetByID(ID id)
        {
            var entities = Stream.ReadAll().ToList();
            var entityToRemove = entities.SingleOrDefault(ent => ent.GetId().CompareTo(id) == 0);
            if (entityToRemove != null)
            { }
                return entityToRemove;
   //         }
            //else
            //{
            //    ThrowEntityNotFoundException("id", id);
            //    return null;
            //}
            //try
            //{
            //    return Stream.ReadAll().SingleOrDefault(ent => ent.GetId().CompareTo(id) == 0);
            //}
            //catch (ArgumentException)
            //{
            //    throw new EntityNotFoundException(string.Format("Greska", EntityName, "id", id));
            //}

        }

        public void Update(T entity)
        {
            try
            {
                var entities = Stream.ReadAll().ToList();
                entities[entities.FindIndex(ent => ent.GetId().CompareTo(entity.GetId()) == 0)] = entity;
                Stream.SaveAll(entities);
            }
            catch (ArgumentException)
            {
                ThrowEntityNotFoundException("id", entity.GetId());
            }
        }

        public void DeleteById(ID id)
        {
            var entities = Stream.ReadAll().ToList();
            var entityToRemove = entities.SingleOrDefault(ent => ent.GetId().CompareTo(id) == 0);
            if (entityToRemove != null)
            {
                entities.Remove(entityToRemove);
                Stream.SaveAll(entities);
            }
            else
            {
                ThrowEntityNotFoundException("id", id);
            }
        }
    }
}