using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;
using RC.MS_Divorcio.Domain.Queries;

namespace RC.MS_Divorcio.Application.Services
{

    public interface IDomicilioConvivenciaService
    {
        public DomicilioConvivencia createDomicilioConvivencia(DomicilioConvivenciaDto domicilio);
        public List<DomicilioConvivenciaDto> GetDomicilios();
    }
    public class DomicilioConvivenciaService: IDomicilioConvivenciaService
    {
        private readonly IGenericsRepository _repository;
        private readonly IDomicilioConvivenciaQuery _query;


        public DomicilioConvivenciaService(IGenericsRepository repository, IDomicilioConvivenciaQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public DomicilioConvivencia createDomicilioConvivencia(DomicilioConvivenciaDto domicilio)
        {
            var entity = new DomicilioConvivencia    //esto parsea un objeto de clase PropuestaDto en un objeto de clase Propuesta
            {
                provinciaId = domicilio.provinciaId,
                localidadId = domicilio.localidadId,
                calle = domicilio.calle,
                numero = domicilio.numero
            };

            _repository.Add<DomicilioConvivencia>(entity);

            return entity;
        }

        public List<DomicilioConvivenciaDto> GetDomicilios()
        {
            return _query.GetDomicilios();

        }
    }
}
