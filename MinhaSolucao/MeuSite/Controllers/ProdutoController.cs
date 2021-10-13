using MeuSite.Models.Business;
using MeuSite.Models.Mapeamento;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MeuSite.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            var list = new ProdutoBusiness().Listar();
            return View(list);
        }

        public JsonResult Listagem()
        {
            var list = new ProdutoBusiness().Listar();
            return Json(list, JsonRequestBehavior.AllowGet);
        }


        List<SelectListItem> ListagemCategoria(int idCategoria = 0)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var listCategorias = new CategoriaBusiness().Listar();
            foreach (var item in listCategorias)
            {
                list.Add(new SelectListItem
                {
                    Value = item.ID.ToString(),
                    Text = item.Nome,
                    Selected = item.ID == idCategoria
                });
            }

            return list;
        }


        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.idcategoria = ListagemCategoria();
            return View(new Produto());
        }

        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            new ProdutoBusiness().Salvar(produto);
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var produto = new ProdutoBusiness().Carregar(id);
            ViewBag.idcategoria = ListagemCategoria(produto.IDCategoria);
            return View(produto);
        }

        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            new ProdutoBusiness().Salvar(produto);

            return RedirectToAction("Index");
        }

    }
}