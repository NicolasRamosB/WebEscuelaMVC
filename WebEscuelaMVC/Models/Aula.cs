using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEscuelaMVC.Models
{
    public class Aula
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Debes ingresar un numero")]
        [Column(TypeName = "varchar(50)")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Debes ingresar un estado")]
        [Column(TypeName = "varchar(50)")]
        public string EstadoDelTipoCadena { get; set; }


    }
}
