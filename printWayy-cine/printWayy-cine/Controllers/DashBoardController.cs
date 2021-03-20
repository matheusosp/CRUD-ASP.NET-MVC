using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Newtonsoft.Json;
using printWayy_cine.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace cine_printWayy.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            foreach(var item in GetFilmes())
            {
                Debug.WriteLine(item);
            }
            return View(GetFilmes());
        }
            
        public ActionResult listAll([DataSourceRequest] DataSourceRequest request)
        {
            Debug.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            return Json(GetFilmes().ToDataSourceResult(request),JsonRequestBehavior.AllowGet);

        }
        private static IEnumerable<Filme> GetFilmes()
        {
            string ApiBaseUrl = "https://cinema-java.herokuapp.com/"; // endereço da sua api
            string MetodoPath = "filmes"; //caminho do método a ser chamado

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(ApiBaseUrl + MetodoPath);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var filmes = new List<Filme>();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    filmes = JsonConvert.DeserializeObject<List<Filme>>(streamReader.ReadToEnd());
                    return filmes.Select(filme => new Filme
                    {
                        id = filme.id,
                        titulo = filme.titulo,
                        descricao = filme.descricao,
                        duracao = filme.duracao,
                    }).ToList();
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}