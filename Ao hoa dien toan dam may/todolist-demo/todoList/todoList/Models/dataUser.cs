using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace todoList.Models
{
    public class User
    {
        public int userId {get; set;}
        public string username {get; set; }
        public string password {get; set; }
        public string email { get; set; }
        public string createAt { get; set; }
    }

    public class todoUser
    {
        public int todoId { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string isComplete { get; set; }
        public string createAt { get; set; }
        public string deadline { get; set; }
        public int prior { get; set; }
    }
}
