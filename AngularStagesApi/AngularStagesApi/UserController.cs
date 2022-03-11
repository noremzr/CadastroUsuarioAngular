using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularStagesDLL.Users;
using AngularStagesDLL;

namespace AngularStagesApi
{
    [Route("api/user")]
    public class UserController : Controller
    {
        [HttpGet]
        public List<User> Get()
        {
            List<User> listaUsuarios = new List<User>();

            using (Context context = new Context())
            {
                UserDAO userDAO = new UserDAO(context);
                listaUsuarios = userDAO.GetUsuarios();
            }
            return listaUsuarios;
        }

        [HttpPost]
        public List<User> Create([FromBody] List<User> listaUsuarios)
        {
            using (Context context = new Context())
            {
                UserDAO userDAO = new UserDAO(context);
                userDAO.SalvarUsuarios(listaUsuarios);
            }
            return listaUsuarios;

        }
    }
}
