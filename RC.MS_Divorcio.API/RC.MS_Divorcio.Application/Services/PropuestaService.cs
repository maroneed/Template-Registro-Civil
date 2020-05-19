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
    public interface IPropuestaService
    {
        public Propuesta CreatePropuesta(PropuestaDto propuesta);
        public List<PropuestaDto> GetPropuestas();
    }

    public class PropuestaService : IPropuestaService
    {
        private readonly IGenericsRepository _repository;
        private readonly IPropuestaQuery _query;


        public PropuestaService(IGenericsRepository repository, IPropuestaQuery query)
        {
            _repository = repository;
            _query = query;
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

        public List<PropuestaDto> GetPropuestas()
        {
            return _query.GetPropuestas();
        }
    }
}
