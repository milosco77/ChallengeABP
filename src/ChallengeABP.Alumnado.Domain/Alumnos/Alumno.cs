using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ChallengeABP.Alumnado.Alumnos
{
    public class Alumno : AuditedAggregateRoot<Guid>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        private Alumno()
        {

        }

        public Alumno(Guid id, string nombre, string apellido, int edad, int dni, string direccion, int telefono) : base(id)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;
            Direccion = direccion;
            Telefono = telefono;
        }

    }
}
