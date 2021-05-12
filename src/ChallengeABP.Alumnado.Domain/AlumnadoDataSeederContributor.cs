using ChallengeABP.Alumnado.Alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace ChallengeABP.Alumnado
{
    public class AlumnadoDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Alumno, Guid> _alumnadoRepository;
        private readonly IGuidGenerator _guidGenerator;


        public AlumnadoDataSeederContributor(IRepository<Alumno, Guid> alumnadoRepository, IGuidGenerator guidGenerator)
        {
            _alumnadoRepository = alumnadoRepository;
            _guidGenerator = guidGenerator;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _alumnadoRepository.GetCountAsync() <= 0)
            {
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Patricio",
                        apellido: "Cordoba",
                        edad: 28,
                        dni: 37035790,
                        direccion: "Jose Bonifacio 656",
                        telefono: 1134693891
                    ),
                    autoSave: true
                );
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Julian",
                        apellido: "Lopez",
                        edad: 27,
                        dni: 35254983,
                        direccion: "Bolivia 470",
                        telefono: 1143592736
                    ),
                    autoSave: true
                );
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Ismael",
                        apellido: "Danna",
                        edad: 27,
                        dni: 35642871,
                        direccion: "Lavalleja 310",
                        telefono: 1165327154
                    ),
                    autoSave: true
                );
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Casiel",
                        apellido: "Chechoni",
                        edad: 28,
                        dni: 37526847,
                        direccion: "Argerich 458",
                        telefono: 1163492517
                    ),
                    autoSave: true
                );
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Ignacio",
                        apellido: "Cozzi",
                        edad: 27,
                        dni: 36547195,
                        direccion: "Alvarez Thomas 3452",
                        telefono: 1136524931
                    ),
                    autoSave: true
                );
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Dean",
                        apellido: "Becerra",
                        edad: 29,
                        dni: 37034628,
                        direccion: "Av Rivadavia 5426",
                        telefono: 1163594276
                    ),
                    autoSave: true
                );
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Juan",
                        apellido: "Portiglia",
                        edad: 27,
                        dni: 35563877,
                        direccion: "Hidalgo 37",
                        telefono: 1121556369
                    ),
                    autoSave: true
                );
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Carmen",
                        apellido: "Contussi",
                        edad: 28,
                        dni: 37548632,
                        direccion: "Av Libertador 5634",
                        telefono: 1155476398
                    ),
                    autoSave: true
                );
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Naara",
                        apellido: "Schonfeld",
                        edad: 29,
                        dni: 36253641,
                        direccion: "Talcahuano 564",
                        telefono: 1199268523
                    ),
                    autoSave: true
                );
                await _alumnadoRepository.InsertAsync(
                    new Alumno(
                        id: _guidGenerator.Create(),
                        nombre: "Lucia",
                        apellido: "Peterson",
                        edad: 18,
                        dni: 90536412,
                        direccion: "Bogota 585",
                        telefono: 1166369825
                    ),
                    autoSave: true
                );

            }
        }
    }
}
