using AutoMapper;
using ChallengeABP.Alumnado.Alumnos;

namespace ChallengeABP.Alumnado
{
    public class AlumnadoApplicationAutoMapperProfile : Profile
    {
        public AlumnadoApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Alumno, AlumnoDto>();
            CreateMap<CreateUpdateAlumnoDto, Alumno>();
        }
    }
}
