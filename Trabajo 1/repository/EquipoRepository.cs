using Microsoft.CodeAnalysis.CSharp.Syntax;
using Trabajo_1.Models;

namespace Trabajo_1.NewFolder1
{
    public class EquipoRepository
    {

        //IEnumerable representa una lista
        public IEnumerable<Equipo> Equipos; //Trabajar en base a esta variable
        public EquipoRepository()
        {
            Equipos = DevuelveListadoEquipos();

        }
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo()
            {
                Id = 1,
                Nombre = "Liga de Quito",
                Logo = "LDU.jpeg",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosPerdidos = 3,
                PartidosEmpatados = 2,
                Descripcion = "Liga Deportiva Universitaria de Quito es un equipo ecuatoriano con una gran historia, fundado en 1930, conocido por su éxito en la Copa Libertadores."

            };
            equipos.Add(ldu);

            Equipo barcelona = new Equipo()
            {
                Id = 2,
                Nombre = "Barcelona",
                Logo = "BARCELONA.png",
                PartidosJugados = 12,
                PartidosGanados = 4,
                PartidosPerdidos = 2,
                PartidosEmpatados = 1,
                Descripcion = "Barcelona Sporting Club es uno de los clubes más exitosos de Ecuador, con sede en Guayaquil. Ha ganado múltiples títulos nacionales e internacionales."

            };
            equipos.Add(barcelona);

            Equipo emelec = new Equipo()
            {
                Id = 3,
                Nombre = "Emelec",
                Logo = "EMELEC.png",
                PartidosJugados = 11,
                PartidosGanados = 6,
                PartidosPerdidos = 1,
                PartidosEmpatados = 4,
                Descripcion = "Club Sport Emelec es otro de los grandes clubes de Ecuador, con sede en Guayaquil. Es conocido por su rivalidad con Barcelona."

            };
            equipos.Add(emelec);

            Equipo delfin = new Equipo()
            {
                Id = 4,
                Nombre = "Delfín",
                Logo = "DELFIN.png",
                PartidosJugados = 10,
                PartidosGanados = 7,
                PartidosPerdidos = 0,
                PartidosEmpatados = 3,
                Descripcion = "Delfín Fútbol Club es un equipo ecuatoriano con sede en Manta, conocido por su destacada trayectoria en la Liga Pro en los últimos años."

            };
            equipos.Add(delfin);
            return (equipos);
        }

        public Equipo DevuelveEquipoPorId(int Id)
            {
                var equipos=DevuelveListadoEquipos();
                var equipo = equipos.First(item => item.Id == Id);


                return equipo;
            }
        public bool ActualizarEquipo(int Id, Equipo equipoActualizado)
        {
            // Obtener el equipo que se desea actualizar
            var equipo = Equipos.FirstOrDefault(e => e.Id == Id);
            if (equipo == null)
            {
                return false; // No se encontró el equipo
            }

            // Actualizar los valores del equipo
            equipo.Nombre = equipoActualizado.Nombre;
            equipo.PartidosJugados = equipoActualizado.PartidosJugados;
            equipo.PartidosGanados = equipoActualizado.PartidosGanados;
            equipo.PartidosPerdidos = equipoActualizado.PartidosPerdidos;
            equipo.PartidosEmpatados = equipoActualizado.PartidosEmpatados;
            equipo.Descripcion = equipoActualizado.Descripcion;

            return true; // Actualización exitosa
        }


    }
}