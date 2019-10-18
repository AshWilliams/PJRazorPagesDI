using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestEF.Models
{
    public class Persona
    {
        public int ID { get; set; }

        [Display(Name = "Nombre Completo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Campo Edad es Requerido")]
        [Range(1,5)]
        public int Edad { get; set; }
    }
}
