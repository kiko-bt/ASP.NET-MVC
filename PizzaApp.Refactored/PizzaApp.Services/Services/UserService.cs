using PizzaApp.DataAccess;
using PizzaApp.DataAccess.CacheRepositories;
using PizzaApp.DataAccess.Repositories;
using PizzaApp.Domain.Enums;
using PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaApp.Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        private IRepository<Feedback> _feedbackRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
            _feedbackRepository = new FeedbackRepository();
        }

        public int AddNewUser(User entity)
        {
            return _userRepository.Insert(entity);
        }


        public string GetLastUserName()
        {
            return _userRepository.GetAll().LastOrDefault().FirstName;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        
        public List<Feedback> GetFeedbacks(int id)
        {
            return _feedbackRepository.GetAll();
        }

        public void GiveFeedback(Feedback entity)
        {
             _feedbackRepository.Insert(entity);
        }
    }
}
