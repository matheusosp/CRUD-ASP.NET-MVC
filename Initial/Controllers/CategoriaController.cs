using Initial.DAO;
using Initial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Initial.Controllers
{
    public class CategoriaController : Controller
    {
        public ActionResult Index()
        {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = dao.Lista();
            ViewBag.Categorias = categorias;
            return View();
        }
    }
}