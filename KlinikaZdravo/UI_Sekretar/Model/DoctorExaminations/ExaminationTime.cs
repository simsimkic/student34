using ClassDiagram.Model.Rooms;
using ClassDiagram.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Model.Users
{
    public class ExaminationTime : IIdentifiable<long>
    {
        public long Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Boolean IsScheduled { get; set; }
        public Room Room { get; set; }

        public ExaminationTime()
        {
            IsScheduled = false;
        }
        public ExaminationTime(long id)
        {
            Id = id;
            IsScheduled = false;
        }
        public ExaminationTime(long id, DateTime fromDate, DateTime toDate, Room room)
        {
            Id = id;
            FromDate = fromDate;
            ToDate = toDate;
            IsScheduled = false;
            Room = room;
        }
        public long GetId() => Id;

        public void SetId(long id) => Id = id;
    }
}
