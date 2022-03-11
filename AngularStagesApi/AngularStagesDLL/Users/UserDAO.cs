using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularStagesDLL.Users
{
    public class UserDAO
    {
        Context UserContext;

        public UserDAO(Context userContext)
        {
            this.UserContext = userContext;
        }

        public List<User> SalvarUsuarios(List<User> listaUsuarios)
        {
            DeleteUsers();
                UserContext.Users.AddRange(listaUsuarios);
            UserContext.SaveChanges();
            return listaUsuarios;
        }

        public List<User> GetUsuarios()
        {
            return UserContext.Users.ToList();
        }

        private void DeleteUsers()
        {
            foreach (User user in UserContext.Users)
            {
                UserContext.Users.Remove(user);
            }
            UserContext.SaveChanges();
        }
    }
}
