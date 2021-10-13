using MeuSite.Models.Business;
using MeuSite.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuSite.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            var lista = new CategoriaBusiness().Listar();
            return View(lista);
        }

        public ActionResult Details(int id)
        {
            var categoria = new CategoriaBusiness().Carregar(id);
            return View(categoria);
        }

        public ActionResult DeleteErro()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (new CategoriaBusiness().Apagar(id))
                return RedirectToAction("Index");
            else
                return RedirectToAction("DeleteErro");
        }

        public ActionResult NovoErro()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Categoria());
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            if (new CategoriaBusiness().Novo(categoria))
                return RedirectToAction("Index");
            else
                return RedirectToAction("NovoErro");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var categoria = new CategoriaBusiness().Carregar(id);
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if (new CategoriaBusiness().Alterar(categoria))
                return RedirectToAction("Index");
            else
                return RedirectToAction("NovoErro");
        }

    }
}