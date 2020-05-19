using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;
using RC.MS_Divorcio.Domain.Queries;

namespace RC.MS_Divorcio.Application.Services
{
    //creamos la interface de IPropuestaService
    public interface ISolicitudTipoService
    {
        public SolicitudTipo CreateSolicitudTipo(SolicitudTipoDto solicitudTipo);
        public List<SolicitudTipoDto> GetSolicitudTipo();
    }
    public class SolicitudTipoService : ISolicitudTipoService
    {
        private readonly IGenericsRepository _repository;
        private readonly ISolicitudTipoQuery _query;


        public SolicitudTipoService(IGenericsRepository repository, ISolicitudTipoQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public SolicitudTipo CreateSolicitudTipo(SolicitudTipoDto solicitudTipo)
        {
            var entity = new SolicitudTipo    //esto parsea un objeto de clase PropuestaDto en un objeto de clase Propuesta
            {
                descripcion = solicitudTipo.descripcion,
                valor = solicitudTipo.valor
            };

            _repository.Add<SolicitudTipo>(entity);

            return entity;
        }

        public List<SolicitudTipoDto> GetSolicitudTipo()
        {
            return _query.GetSolicitudTipo();
        }
    }
}
