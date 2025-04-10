using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Trabajo_1.Models;
using Trabajo_1.NewFolder1;

namespace Trabajo_1.Controllers
{
    public class EquipoController : Controller
    {
        //Esto maneja todo el codigo para no tener que inicializar el repository a cada rato, solo se lo llama
        public EquipoRepository _repository;
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }
        public ActionResult View()
        {
            return View();
        }

        public ActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos();

            equipos = equipos.OrderBy(item => item.PartidosGanados);
            return View(equipos);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var equipo = _repository.DevuelveEquipoPorId(Id);
            return View(equipo);

        }

        [HttpPost] //para guardar o actualizar 
        public ActionResult Edit (int Id, Equipo equipo)
        {
            //Proceso de guardar
            try
            {
                _repository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }

        }

        public IActionResult View(int id)
        {
            var equipo = _repository.DevuelveEquipoPorId(id); 
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }

        public IActionResult Detalles(int id)
        {
            var equipo = _repository.DevuelveEquipoPorId(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo); // Esto busca la vista "Detalles.cshtml"
        }


    }
}

