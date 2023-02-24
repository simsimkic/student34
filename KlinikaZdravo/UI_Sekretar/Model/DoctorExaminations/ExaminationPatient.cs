using ClassDiagram.Model.DoctorExaminations;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using System.Collections.Generic;


namespace KlinikaZdravo.Model.DoctorExaminations
{
    public class ExaminationPatient : IIdentifiable<long>
    {
        public long Id { get; set; }
        public Diagnosis Diagnosis { get; set; }
        public List<Refferal> Refferals { get; set; }
        public Patient Patient { get; set; }

        public ExaminationPatient() { }
        public ExaminationPatient(long id)
        {
            id = id;
        }
        public ExaminationPatient(long id, Diagnosis diagnosis, List<Refferal> refferals, Patient patient)
        {
            Id = id;
            Diagnosis = diagnosis;
            Refferals = refferals;
            Patient = patient;
        }

        /// <summary>
        /// Property for collection of Refferal
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public List<Refferal> RefferalCollection
        {
            get
            {
                if (Refferals == null)
                    Refferals = new List<Refferal>();
                return Refferals;
            }
            set
            {
                RemoveAllRefferal();
                if (value != null)
                {
                    foreach (Refferal oRefferal in value)
                        AddRefferal(oRefferal);
                }
            }
        }


        /// <summary>
        /// Add a new Refferal in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddRefferal(Refferal newRefferal)
        {
            if (newRefferal == null)
                return;
            if (Refferals == null)
                Refferals = new List<Refferal>();
            if (!Refferals.Contains(newRefferal))
                Refferals.Add(newRefferal);
        }

        /// <summary>
        /// Remove an existing Refferal from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveRefferal(Refferal oldRefferal)
        {
            if (oldRefferal == null)
                return;
            if (Refferals != null)
                if (Refferals.Contains(oldRefferal))
                    Refferals.Remove(oldRefferal);
        }

        /// <summary>
        /// Remove all instances of Refferal from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllRefferal()
        {
            if (Refferals != null)
                Refferals.Clear();
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}
