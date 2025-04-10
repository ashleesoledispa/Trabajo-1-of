using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Trabajo_1.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del equipo es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El nombre del equipo debe tener menos de 100 caracteres.")]
        [MinLength(3, ErrorMessage = "El nombre del equipo debe tener al menos 3 caracteres.")]
        [DisplayName("Nombre del equipo")]
        public string Nombre { get; set; }
        [Range(0, 100)]
        public int PartidosJugados { get; set; }
        [Range(0, 100)]
        public int PartidosGanados { get; set; }
        [Range(0, 100)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 100)]
        public int PartidosEmpatados { get; set; }
        public string Logo { get; set; }
        public string Descripcion { get; set; }



    }
}
