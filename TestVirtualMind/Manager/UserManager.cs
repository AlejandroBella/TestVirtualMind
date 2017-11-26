using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestVirtualMind.Entidades;
using TestVirtualMind.Interfaces;

namespace TestVirtualMind.Manager
{
    public class UserManager: IUserManager
    {
       /*
         * Ls metdos de insert update y delete devuelven un booleano indicando que la operacion tuvo un impacto sobre la BD más alla de no
         * generar un error, por ej: se actualizó un registro porque existia el id.
       */ 
        public List<Usuario> GetAllUser()
        {
            var list = new List<Usuario>();
            using (var db = new VMDBEntities())
            {
                var result = db.Users.ToList<User>();
                foreach (var u in result)
                {
                    list.Add(new Usuario
                    {
                        Id = u.Id,
                        Apellido = u.Apellido,
                        Email = u.Email,
                        Nombre = u.Nombre,
                        Password = u.Password
                    });
                }
            }
            return list;

        }

        public bool CreateUser(Usuario user)
        {
           var dbUser = new User()
                {
                    Apellido = user.Apellido,
                    Email = user.Email,
                    Nombre = user.Nombre,
                    Password = user.Password
                };
                using (var db = new VMDBEntities())
                {
                    db.Users.Add(dbUser);
                    db.SaveChanges();
                }
                return true;
           
        }

        public bool UpdateUser(Usuario user)
        {
                 using (var db = new VMDBEntities())
                {
                    var dbUser = db.Users.Find(user.Id);
                if (dbUser != null)
                {
                    dbUser.Apellido = user.Apellido;
                    dbUser.Email = user.Email;
                    dbUser.Nombre = user.Nombre;
                    dbUser.Password = user.Password;

                    db.SaveChanges();
                }
                else return false;
                }
                return true;
           
        }

        public bool DeleteUser(int userId)
        {
                using (var db = new VMDBEntities())
                {
                    var dbUser = db.Users.Find(userId);
                    if (dbUser != null)
                    {
                        db.Users.Remove(dbUser);
                        db.SaveChanges();
                }
                else return false;
            }
                return true;
           
        }



    }
}