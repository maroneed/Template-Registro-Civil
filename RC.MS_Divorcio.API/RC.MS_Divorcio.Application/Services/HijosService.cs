using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;
using RC.MS_Divorcio.Domain.Queries;

namespace RC.MS_Divorcio.Application.Services
{
    public interface IHijosService
    {
        public Hijos createHijos(HijosDto hijos);
        public List<HijosDto> GetHijos();

    }

    public class HijosService: IHijosService
    {
        private readonly IGenericsRepository _repository;
        private readonly IHijosQuery _query;


        public HijosService(IGenericsRepository repository, IHijosQuery query)
        {
            _repository = repository;
            _query = query;
        }

        public Hijos createHijos(HijosDto hijos)
        {
            var entity = new Hijos    //esto parsea un objeto de clase PropuestaDto en un objeto de clase Propuesta
            {
                personaId = hijos.personaId,
                detallehijosId = hijos.detallehijosId
            };

            _repository.Add<Hijos>(entity);

            return entity;
        }

        public List<HijosDto> GetHijos()
        {
            return _query.GetHijos();
        }
    }
}
