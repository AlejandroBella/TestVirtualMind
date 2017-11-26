using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVirtualMind.Entidades;

namespace TestVirtualMind.Interfaces
{
    public interface IUserManager
    {
        List<Usuario> GetAllUser();

        bool CreateUser(Usuario user);
        bool UpdateUser(Usuario user);
        bool DeleteUser(int userId);
    }
}
