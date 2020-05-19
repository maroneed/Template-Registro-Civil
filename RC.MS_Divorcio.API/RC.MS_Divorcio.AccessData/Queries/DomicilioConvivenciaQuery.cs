using RC.MS_Divorcio.Domain.DTOs;
using RC.MS_Divorcio.Domain.Queries;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RC.MS_Divorcio.AccessData.Queries
{
    public class DomicilioConvivenciaQuery: IDomicilioConvivenciaQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public DomicilioConvivenciaQuery(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<DomicilioConvivenciaDto> GetDomicilios()
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("DomicilioConvivencia");

            var result = query.Get<DomicilioConvivenciaDto>();

            return result.ToList();
        }
    }
}
