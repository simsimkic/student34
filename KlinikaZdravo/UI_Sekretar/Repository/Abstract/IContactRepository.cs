using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Repository.Abstract
{
    public interface IContactRepository : IRepository<Contact, long>
    {
    }
}
