using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Domain.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
