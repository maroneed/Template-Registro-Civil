using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;

namespace RC.MS_Divorcio.Application.Services
{
    //creamos la interface de IPropuestaService
    public interface ISolicitudTipoService
    {
        public SolicitudTipo CreateSolicitudTipo(SolicitudTipoDto solicitudTipo);
    }
    public class SolicitudTipoService : ISolicitudTipoService
    {
        private readonly IGenericsRepository _repository;

        public SolicitudTipoService(IGenericsRepository repository)
        {
            _repository = repository;
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
    }
}
