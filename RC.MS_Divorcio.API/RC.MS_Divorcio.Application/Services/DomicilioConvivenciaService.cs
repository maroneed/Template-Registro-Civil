using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;

namespace RC.MS_Divorcio.Application.Services
{

    public interface IDomicilioConvivenciaService
    {
        public DomicilioConvivencia createDomicilioConvivencia(DomicilioConvivenciaDto domicilio);
    }
    public class DomicilioConvivenciaService: IDomicilioConvivenciaService
    {
        private readonly IGenericsRepository _repository;

        public DomicilioConvivenciaService(IGenericsRepository repository)
        {
            _repository = repository;
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
    }
}
