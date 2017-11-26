using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestVirtualMind.Entidades;
using TestVirtualMind.Interfaces;

namespace TestVirtualMind.Mocks
{
    public class UserManagerMock : IUserManager
    {
        public bool CreateUser(Usuario user)
        {
            return true;
        }

        public bool DeleteUser(int userId)
        {
            return true;   
        }

        public List<Usuario> GetAllUser()
        {
            return new List<Usuario>()
            {
                new Entidades.Usuario()
                {
                    Apellido = "Bella", Nombre = "Alejandro", Email = "no@gmail.com", Password = "1234"
                },
                new Entidades.Usuario()
                {
                    Apellido = "Juarez", Nombre = "Pepe", Email = "pepe@pepa.com", Password = "1234"
                }
            };
        }

        public bool UpdateUser(Usuario user)
        {
            return true;
        }
    }
}