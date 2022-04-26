using System.ComponentModel.DataAnnotations;

namespace ServicioData
{
    public class Nota
    {
        [Key]
        public int IdNota { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaHora { get; set; }
    }
}