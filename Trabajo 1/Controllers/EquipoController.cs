using Microsoft.AspNetCore.Mvc;
using Trabajo_1.Models;
using Trabajo_1.NewFolder1;

namespace Trabajo_1.Controllers
{
    public class EquipoController : Controller
    {
        // Repositorio
        private readonly EquipoRepository _repository;

        public EquipoController()
        {
            _repository = new EquipoRepository();
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

        public ActionResult Edit(int id)
        {
            var equipo = _repository.DevuelveEquipoPorId(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Equipo equipo)
        {
            if (id != equipo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var actualizado = _repository.ActualizarEquipo(id, equipo);
                if (actualizado)
                {
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    return NotFound();
                }
            }

            return View(equipo);
        }

        // Acción para ver los detalles de un equipo
        public IActionResult Detalles(int id)
        {
            var equipo = _repository.DevuelveEquipoPorId(id);
            if (equipo == null)
            {
                return NotFound();
            }
            return View(equipo);
        }


    }
}
