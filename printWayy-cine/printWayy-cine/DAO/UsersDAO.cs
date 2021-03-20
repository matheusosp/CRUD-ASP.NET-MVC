using cine_printWayy.Models;
using cine_printWayy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cine_printWayy.DAO
{
    public class UsersDAO
    {
        public void Create(User user)
        {
            using (var context = new UserRepository())
            {
                context.Create(user);
            }
        }


        public User Find(string login, string senha)
        {
            using (var contexto = new UserRepository())
            {
                return contexto.Find(login, senha);
            }
        }
    }
}