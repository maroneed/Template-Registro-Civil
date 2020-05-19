using System;
using System.Collections.Generic;
using System.Text;
using RC.MS_Divorcio.Domain.DTOs;
using SqlKata;
using SqlKata.Execution;
namespace RC.MS_Divorcio.Domain.Queries
{
    public interface IDomicilioConvivenciaQuery
    {
        public List<DomicilioConvivenciaDto> GetDomicilios();

    }
}
