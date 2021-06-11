using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVentas.Models.Interface;

namespace WebAppVentas.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly IProveedorRepository _proveedorRepository;
        public ProveedorController(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }
        public IActionResult Index()
        {
            return View(_proveedorRepository.GetAllProveedores());
        }
    }
}
