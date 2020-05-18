using RC.MS_Divorcio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Commands;

namespace RC.MS_Divorcio.Application.Services
{
    public interface IHijosService
    {
        public Hijos createHijos(HijosDto hijos);
    }
    
    public class HijosService: IHijosService
    {
        private readonly IGenericsRepository _repository;

        public HijosService(IGenericsRepository repository)
        {
            _repository = repository;
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
    }
}
