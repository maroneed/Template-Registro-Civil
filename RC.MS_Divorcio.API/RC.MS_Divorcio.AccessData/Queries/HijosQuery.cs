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
    public class HijosQuery: IHijosQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public HijosQuery(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<HijosDto> GetHijos()
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Hijos");

            var result = query.Get<HijosDto>();

            return result.ToList();
        }

    }
}
