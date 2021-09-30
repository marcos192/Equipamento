using Equipamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Equipamento.Controllers
{
    public class CategoriasController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>()
            {
                new Categoria()
                    {
                        CategoriaId = 1,
                        Nome = "Notebooks"
                    },

                new Categoria()
                    {
                        CategoriaId = 2,
                        Nome = "Monitores"
                    },

                new Categoria()
                    {
                        CategoriaId = 3,
                        Nome = "Impressoras"
                    }
            };

        // GET: Categorias
        public ActionResult Index()
        {
         return View(categorias);
        }

        // GET: Categoria
        public ActionResult Create()
        {
         return View();
        }
    }
}