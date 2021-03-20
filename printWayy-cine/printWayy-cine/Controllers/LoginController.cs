using cine_printWayy.DAO;
using cine_printWayy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cine_printWayy.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            var user = new User();
            user.Username = form["Nome"];
            user.Password = form["Password"];
            var dao = new UsersDAO();
            dao.Create(user);
            return RedirectToAction("Index");
        }
        // GET: Login
        public ActionResult Authenticate(User loginCredentials)
        {
            var dao = new UsersDAO();
            var usuario = dao.Find(loginCredentials.Username, loginCredentials.Password);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "DashBoard");
            }
            return RedirectToAction("Index");
        }
    }
}