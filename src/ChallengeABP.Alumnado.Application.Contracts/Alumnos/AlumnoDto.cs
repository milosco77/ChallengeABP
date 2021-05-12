using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace ChallengeABP.Alumnado.Alumnos
{
    public class AlumnoDto : AuditedEntityDto<Guid>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

    }
}
