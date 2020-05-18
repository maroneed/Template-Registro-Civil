using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;

namespace RC.MS_Divorcio.Application.Services
{
    
    //creamos la interface de IPropuestaService
    public interface IPropuestaService
    {
        public Propuesta CreatePropuesta(PropuestaDto propuesta);
    }

    public class PropuestaService : IPropuestaService
    {
        private readonly IGenericsRepository _repository;

        public PropuestaService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public Propuesta CreatePropuesta(PropuestaDto propuesta)
        {
            var entity = new Propuesta    //esto parsea un objeto de clase PropuestaDto en un objeto de clase Propuesta
            {
                descripcion = propuesta.descripcion
            };

            _repository.Add<Propuesta>(entity);

            return entity;
        }
    }
}
