using System.Web.Http;
using TestVirtualMind.Entidades;
using TestVirtualMind.Interfaces;
using TestVirtualMind.Manager;

namespace TestVirtualMind.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {

        IUserManager ManagerUser;

        public UserController()
        {
            ManagerUser = new TestVirtualMind.Manager.UserManager();
        }

        public UserController(IUserManager Manager)
        {
            if (Manager != null)
                ManagerUser = Manager;
            else
                ManagerUser = new TestVirtualMind.Manager.UserManager();
        }

        [HttpGet]
        [Route("GetUsers")]
        public IHttpActionResult GetUsers()
        {
            var users = ManagerUser.GetAllUser();
            if (users != null)
                return Ok(users);
            else
                return NotFound();
        }

        [HttpPost]
        [Route("CreateUser")]
        public IHttpActionResult CreateUser(Usuario user)
        {
            if(user!=null && user.Id==0)
            {
                try
                {
                    ManagerUser.CreateUser(user);
                    return Ok();
                }
                catch(System.Exception ex)
                {
                    //En una pp standar ex seria logueada en un archivo o tabla de la base de datos.
                    //no seria devuelta al exterior para no comprometer información o estructura interna del sistema
                    return InternalServerError();
                }
            }
            else
            {
                //si ya tieviese una PK podria existir por lo tanto se asume como error 
                // antes de que llegue a la capa de datos.
                return InternalServerError();
            }
        }

        [HttpPost]
        [Route("UpdateUser")]
        public IHttpActionResult UpdateUser(Usuario user)
        {
            if (user != null && user.Id > 0)
            {
                try
                {
                    ManagerUser.UpdateUser(user);
                    return Ok();
                }
                catch (System.Exception ex)
                {
                    //En una App standar ex seria logueada en un archivo o tabla de la base de datos.
                    //no seria devuelta al exterior para no comprometer información o estructura interna del sistema
                    return InternalServerError();
                }
            }
            else
            {
                //si no tueviese una PK no es posible el update, se levanta exception 
                // antes de que llegue a la capa de datos.
                return InternalServerError();
            }
        }

        [HttpGet]
        [Route("DeleteUser")]
        public IHttpActionResult DeleteUser(int userId)
        {
            if (userId > 0)
            {
                try
                {
                    ManagerUser.DeleteUser(userId);
                    return Ok();
                }
                catch (System.Exception ex)
                {
                    //En una App standar ex seria logueada en un archivo o tabla de la base de datos.
                    //no seria devuelta al exterior para no comprometer información o estructura interna del sistema
                    return InternalServerError();
                }
            }
            else
            {
                //si no tueviese una PK no es posible el borrado, se levanta exception 
                // antes de que llegue a la capa de datos.
                return InternalServerError();
            }
        }
    }
}
