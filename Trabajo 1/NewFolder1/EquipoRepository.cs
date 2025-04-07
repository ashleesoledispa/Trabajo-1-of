using Microsoft.CodeAnalysis.CSharp.Syntax;
using Trabajo_1.Models;

namespace Trabajo_1.NewFolder1
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo()
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosPerdidos = 3,
                PartidosEmpatados = 2

            };
            equipos.Add(ldu);

            Equipo barcelona = new Equipo()
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosJugados = 12,
                PartidosGanados = 4,
                PartidosPerdidos = 2,
                PartidosEmpatados = 1

            };
            equipos.Add(barcelona);

            Equipo emelec = new Equipo()
            {
                Id = 3,
                Nombre = "Emelec",
                PartidosJugados = 11,
                PartidosGanados = 6,
                PartidosPerdidos = 1,
                PartidosEmpatados = 4

            };
            equipos.Add(emelec);

            Equipo delfin = new Equipo()
            {
                Id = 4,
                Nombre = "Delfín",
                PartidosJugados = 10,
                PartidosGanados = 7,
                PartidosPerdidos = 0,
                PartidosEmpatados = 3

            };
            equipos.Add(delfin);
            return (equipos);
        }
    }
}
   