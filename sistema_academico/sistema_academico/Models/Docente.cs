using System.ComponentModel.DataAnnotations;
namespace sistema_academico.Models

{
    public class Docente
    {
        [Key]
        public int idDocente { get; set; }
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        //byte intermedio entre numeros y letras 
        public byte[] foto { get; set; }
    }
}
