using ChallengeABP.Alumnado.Alumnos;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ChallengeABP.Alumnado.EntityFrameworkCore
{
    public static class AlumnadoDbContextModelCreatingExtensions
    {
        public static void ConfigureAlumnado(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Alumno>(a =>
            {
                a.ToTable(AlumnadoConsts.DbTablePrefix + "Alumnos",
                          AlumnadoConsts.DbSchema);
                a.ConfigureByConvention();
                a.Property(x => x.Nombre).IsRequired().HasMaxLength(128);
                a.Property(x => x.Apellido).IsRequired().HasMaxLength(128);
                a.Property(x => x.Edad).HasMaxLength(2);
                a.Property(x => x.Dni).IsRequired().HasMaxLength(128);
                a.Property(x => x.Direccion).HasMaxLength(128);
                a.Property(x => x.Telefono).HasMaxLength(128);
            });
        }
    }
}