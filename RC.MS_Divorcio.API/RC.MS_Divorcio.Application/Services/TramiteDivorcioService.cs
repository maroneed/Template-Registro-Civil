using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;
using RC.MS_Divorcio.Domain.Queries;

namespace RC.MS_Divorcio.Application.Services
{
    public interface ITramiteDivorcioService
    {
        public TramiteDivorcio createTramiteDivorcio(RegistroTramiteDto tramite);
        public List <TramiteDivorcioDto> GetTramites();

    }
    public class TramiteDivorcioService: ITramiteDivorcioService
    {
        private readonly IGenericsRepository _repository;
        private readonly ITramiteDivorcioQuery _query;


        public TramiteDivorcioService(IGenericsRepository repository, ITramiteDivorcioQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public TramiteDivorcio createTramiteDivorcio(RegistroTramiteDto tramite)
        {
            var domicilio = new DomicilioConvivencia
            {
                calle = tramite.calle,
                numero = tramite.numero,
                localidadId = tramite.localidadId,
                provinciaId = tramite.provinciaId
            };

            _repository.Add<DomicilioConvivencia>(domicilio);


            var propuesta = new Propuesta
            {
                descripcion = tramite.propuesta
            };

            _repository.Add<Propuesta>(propuesta);


            var TramiteDivorcio = new TramiteDivorcio    //esto parsea un objeto de clase PropuestaDto en un objeto de clase Propuesta
            {
                personaId1 = tramite.idPersona1,
                personaId2 = tramite.idPersona2,
                actaMatrimonioId = tramite.actaMatrimonioId,
                domicilioConyugalId = domicilio.Id,
                propuestaId = propuesta.Id,
                solicitudTipoId = tramite.solicitudTipoId,
                fecha = DateTime.Now

            };

            _repository.Add<TramiteDivorcio>(TramiteDivorcio);

            return TramiteDivorcio;
        }

        public List <TramiteDivorcioDto> GetTramites()
        {
            return _query.GetTramites();
        }
    }
}
