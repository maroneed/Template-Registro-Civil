using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;

namespace RC.MS_Divorcio.Application.Services
{
    public interface IDetalleHijosService
    {
        public DetalleHijos createDetalleHijos(DetalleHijosDto detalleHijos);
    }
    public class DetalleHijosService: IDetalleHijosService
    {
        private readonly IGenericsRepository _repository;

        public DetalleHijosService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public DetalleHijos createDetalleHijos(DetalleHijosDto detalleHijos)
        {
            var entity = new DetalleHijos    //esto parsea un objeto de clase PropuestaDto en un objeto de clase Propuesta
            {
                
            };

            _repository.Add<DetalleHijos>(entity);

            return entity;
        }
    }
}
