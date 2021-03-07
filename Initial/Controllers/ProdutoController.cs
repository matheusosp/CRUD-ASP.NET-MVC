using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Initial.DAO;
using Initial.Models;

namespace Initial.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Index()
        {
            ProdutosDAO dao = new ProdutosDAO();
            IList<Produto> produtos = dao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }
    }
}