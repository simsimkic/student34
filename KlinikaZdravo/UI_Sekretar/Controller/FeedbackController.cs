using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Service.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Controller
{
    public class FeedbackController : IController<Feedback, long>
    {

        private static FeedbackController Instance;
        private readonly IService<Feedback, long> Service;

        public FeedbackController(IService<Feedback, long> service)
        {
            Service = service;
        }
        public static FeedbackController GetInstance(IService<Feedback, long> service)
        {
            if (Instance == null)
            {
                Instance = new FeedbackController(service);
            }
            return Instance;
        }

        public IEnumerable<Feedback> GetAll() => Service.GetAll();
        public Feedback GetByID(long id) => Service.Get(id);
        public Feedback Create(Feedback feedback) => Create(feedback);
        public void Update(Feedback feedback) => Update(feedback);
        public void Delete(Feedback feedback) => Delete(feedback);
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteById(long v)
        {
            throw new NotImplementedException();
        }
    }
}
