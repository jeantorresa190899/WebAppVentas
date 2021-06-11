using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVentas.Models;
using WebAppVentas.Models.Interface;
namespace WebAppVentas.Controllers
{
    public class DistritoController : Controller
    {
        private readonly IDistritoRepository _distritoRepository;
        public DistritoController(IDistritoRepository distritoRepository)
        {
            _distritoRepository = distritoRepository;
        }
        public IActionResult Index()
        {
            return View(_distritoRepository.GetAllDistritos());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateDistrito(TbDistrito distrito)
        {
            if (ModelState.IsValid)
            {
                _distritoRepository.Add(distrito);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create");
            }
        }

        public IActionResult EditDistrito(TbDistrito distrito)
        {
            if (ModelState.IsValid)
            {
                _distritoRepository.EditDetails(distrito);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit");
            }
        }



        [Route("Distrito/Delete/{CodDis}")]
        public IActionResult Delete(string CodDis)
        {
            _distritoRepository.Remove(CodDis);
            return RedirectToAction("Index");
        }


        [Route("Distrito/Edit/{CodDis}")]
        public IActionResult Edit(string CodDis)
        {
            var obj = _distritoRepository.Edit(CodDis);
            ViewData["cod"] = obj.CodDis;
            ViewData["nom"] = obj.NomDis;
            return View();
        }
    }
}
