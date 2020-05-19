using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;
using RC.MS_Divorcio.Domain.Queries;

namespace RC.MS_Divorcio.Application.Services
{
    public interface IDetalleHijosService
    {
        public DetalleHijos createDetalleHijos(DetalleHijosDto detalleHijos);
        public List<DetalleHijosDto> GetDetalleHijos();
    }
    public class DetalleHijosService: IDetalleHijosService
    {
        private readonly IGenericsRepository _repository;
        private readonly IDetalleHijosQuery _query;


        public DetalleHijosService(IGenericsRepository repository, IDetalleHijosQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public DetalleHijos createDetalleHijos(DetalleHijosDto detalleHijos)
        {
            var entity = new DetalleHijos    //esto parsea un objeto de clase PropuestaDto en un objeto de clase Propuesta
            {
                
            };

            _repository.Add<DetalleHijos>(entity);

            return entity;
        }

        public List<DetalleHijosDto> GetDetalleHijos()
        {
            return _query.GetDetalleHijos();
        }
    }
}
