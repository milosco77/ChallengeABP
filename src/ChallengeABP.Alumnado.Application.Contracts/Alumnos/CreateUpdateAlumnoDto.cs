using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChallengeABP.Alumnado.Alumnos
{
    public class CreateUpdateAlumnoDto
    {
        [Required, StringLength(128)]
        public string Nombre { get; set; }
        [Required, StringLength(128)]
        public string Apellido { get; set; }
        public int Edad { get; set; }
        [Required]
        public int Dni { get; set; }
        [StringLength(128)]
        public string Direccion { get; set; }
        public int Telefono { get; set; }

    }
}
