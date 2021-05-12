using AutoMapper;
using ChallengeABP.Alumnado.Alumnos;

namespace ChallengeABP.Alumnado.Blazor
{
    public class AlumnadoBlazorAutoMapperProfile : Profile
    {
        public AlumnadoBlazorAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Blazor project.
            CreateMap<AlumnoDto, CreateUpdateAlumnoDto>();
        }
    }
}
