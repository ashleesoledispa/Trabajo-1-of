using Microsoft.AspNetCore.Mvc;
using Trabajo_1.Models;
using Trabajo_1.NewFolder1;

namespace Trabajo_1.Controllers
{
    public class EquipoController : Controller
    {
        // Repositorio
        private readonly EquipoRepository _repository;

        // Constructor
        public EquipoController()
        {
            _repository = new EquipoRepository();
        }

        // Acción para mostrar la lista de equipos
        public ActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            equipos = equipos.OrderBy(item => item.PartidosGanados);
            return View(equipos);
        }

        // Acción para crear un nuevo equipo
        public ActionResult Create()
        {
            return View();
        }

        // Acción para mostrar el formulario de edición (GET)
        public ActionResult Edit(int id)
        {
            var equipo = _repository.DevuelveEquipoPorId(id); // Obtener el equipo por su ID
            if (equipo == null)
            {
                return NotFound(); // Si no se encuentra el equipo, devuelve un error 404
            }
            return View(equipo); // Pasa el modelo (equipo) a la vista
        }

        // Acción para procesar la edición del equipo (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Equipo equipo)
        {
            if (id != equipo.Id) // Verifica si el ID no coincide
            {
                return NotFound(); // Si el ID no coincide, devuelve un error 404
            }

            if (ModelState.IsValid)
            {
                var actualizado = _repository.ActualizarEquipo(id, equipo); // Llama al repositorio para actualizar
                if (actualizado)
                {
                    return RedirectToAction(nameof(List)); // Redirige a la lista después de la actualización
                }
                else
                {
                    return NotFound(); // Si no se pudo actualizar, devuelve un error
                }
            }

            return View(equipo); // Si el modelo no es válido, vuelve a mostrar el formulario con los errores
        }

        // Acción para ver los detalles de un equipo
        public IActionResult Detalles(int id)
        {
            var equipo = _repository.DevuelveEquipoPorId(id);
            if (equipo == null)
            {
                return NotFound(); // Si no se encuentra el equipo, devuelve un error 404
            }
            return View(equipo); // Pasa el modelo (equipo) a la vista
        }
    }
}
