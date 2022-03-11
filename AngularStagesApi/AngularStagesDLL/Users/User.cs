using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AngularStagesDLL.Users
{
    [Table("MvtUser")]
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }

        public User() : this(string.Empty, string.Empty, string.Empty, string.Empty) { }

        public User(string userName, string password, string email, string name)
        {
            this.UserName = userName;
            this.Password = password;
            this.Email = email;
            this.Name = name;

        }

    }
}
