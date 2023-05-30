using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPessoal.Web.Controllers
{
    public class CategoriasDeProdutoController : Controller
    {
        // GET: CategoriasDeProduto
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Teste(int id)
        {
            ViewBag.Message = id;
            if (id != 0)
                Response.Write($"<h1> Teste - Query String </h2> ID = {id}");

            return View();
        }

        [HttpGet]
        public ActionResult TesteModelClass(Filtro filtro)
        {
            ViewBag.Message = filtro.Id;
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            string nome = form["nome"];
            if (!string.IsNullOrEmpty(nome))
                Response.Write("<h2> Sucesso </h2> Categoria Salva...");
            else
                Response.Write("<h2> Falha </h2> Categoria inválida...");

            return View();
        }
    }

    public class Filtro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}