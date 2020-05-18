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
        public TramiteDivorcio createTramiteDivorcio(TramiteDivorcioDto tramite);
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

        public TramiteDivorcio createTramiteDivorcio(TramiteDivorcioDto tramite)
        {
            var entity = new TramiteDivorcio    //esto parsea un objeto de clase PropuestaDto en un objeto de clase Propuesta
            {
                personaId1 = tramite.personaId1,
                personaId2 = tramite.personaId2,
                actaMatrimonioId = tramite.actaMatrimonioId,
                domicilioConyugalId = tramite.domicilioConyugalId,
                propuestaId = tramite.propuestaId,
                detalleHijosId = tramite.detalleHijosId,
                fecha = DateTime.Now

            };

            _repository.Add<TramiteDivorcio>(entity);

            return entity;
        }

        public List <TramiteDivorcioDto> GetTramites()
        {
            return _query.GetTramites();
        }
    }
}
