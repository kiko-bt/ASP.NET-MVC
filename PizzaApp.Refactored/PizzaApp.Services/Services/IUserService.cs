using PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Services.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        int AddNewUser(User entity);
        string GetLastUserName();
        void GiveFeedback(Feedback entity);
        List<Feedback> GetFeedbacks(int id);
    }
}
