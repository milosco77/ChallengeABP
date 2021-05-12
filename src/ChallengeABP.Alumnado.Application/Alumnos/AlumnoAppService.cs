using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ChallengeABP.Alumnado.Alumnos
{
    public class AlumnoAppService :
                CrudAppService<Alumno, AlumnoDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateAlumnoDto>, IAlumnoAppService
    {
        public AlumnoAppService(IRepository<Alumno, Guid> repository)
            : base(repository)
        {

        }
    }
}
