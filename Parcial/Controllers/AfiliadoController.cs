using Parcial.Domain.Parcial.Business;
using Parcial.Domain.Parcial.Data.Services;
using Parcial.Shared.Parcial.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial.Controllers
{
    public class AfiliadoController : Controller
    {
        public ActionResult Afiliado()
        {
            var biz = new AfiliadoBiz();
            var model = biz.Listar();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Afiliado model)
        {
            try
            {
                var biz = new AfiliadoBiz();
                biz.Agregar(model);
                return RedirectToAction("Afiliado", "Afiliado");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            try
            {
                var biz = new AfiliadoBiz();
                var model = biz.BuscarId(id);
                if (model == null)
                    throw new Exception();
                return View(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToAction("Afiliado", "Afiliado");
            }
        }

        [HttpPost]
        public ActionResult Update(Afiliado model)
        {
            try
            {
                var biz = new AfiliadoBiz();
                biz.Editar(model);
                return RedirectToAction("Afiliado", "Afiliado");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                var biz = new AfiliadoBiz();
                var model = biz.BuscarId(id);
                if (model == null)
                    throw new Exception();
                return View(model);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToAction("Afiliado", "Afiliado");
            }
        }

        [HttpPost]
        public ActionResult Delete(Afiliado model)
        {

            try
            {
                var biz = new AfiliadoBiz();
                biz.Delete(model.Id);
                return RedirectToAction("Afiliado", "Afiliado");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(model);
            }
        }
    }
}
