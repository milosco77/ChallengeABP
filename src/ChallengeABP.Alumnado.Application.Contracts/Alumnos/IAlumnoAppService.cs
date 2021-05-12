using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ChallengeABP.Alumnado.Alumnos
{
    public interface IAlumnoAppService : ICrudAppService<AlumnoDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateAlumnoDto>
    {

    }

}
