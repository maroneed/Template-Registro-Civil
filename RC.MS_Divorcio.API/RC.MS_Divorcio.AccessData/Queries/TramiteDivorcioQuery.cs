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
    public class TramiteDivorcioQuery: ITramiteDivorcioQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public TramiteDivorcioQuery(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List <TramiteDivorcioDto> GetTramites()
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("TramiteDivorcios");

            var result = query.Get<TramiteDivorcioDto>();

            return result.ToList();
        }

        public RegistroDeConsultaDto GetDivorcioPorActa(int actaMatrimonioId)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var tramite = db.Query("TramiteDivorcios")
                .Select("TramiteDivorcios.actaMatrimonioId", "Propuestas.descripcion as propuesta", "TramiteDivorcios.personaId1 as idPersona1" , "TramiteDivorcios.personaId2 as idPersona2",
                "TramiteDivorcios.fecha")
                .Where("TramiteDivorcios.actaMatrimonioId", "=", actaMatrimonioId)
                .Join("Propuestas", "Propuestas.id", "TramiteDivorcios.propuestaId")
                .FirstOrDefault<RegistroDeConsultaDto>();

            if (tramite != null)
            {
                return new RegistroDeConsultaDto
                {
                    actaMatrimonioId = tramite.actaMatrimonioId,
                    idPersona1 = tramite.idPersona1,
                    idPersona2 = tramite.idPersona2,
                    propuesta = tramite.propuesta,
                    fecha = tramite.fecha
                    
                };
            }
            else
            {
                return null;
            }
        }

        public RegistroDeConsultaDto GetDivorcioPorPersonaId(int idPersona1)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var tramite = db.Query("TramiteDivorcios")
                .Select("TramiteDivorcios.actaMatrimonioId", "Propuestas.descripcion as propuesta", "TramiteDivorcios.personaId1 as idPersona1", "TramiteDivorcios.personaId2 as idPersona2",
                "TramiteDivorcios.fecha")
                .Where("TramiteDivorcios.personaId1", "=", idPersona1)
                .Or()
                .Where("TramiteDivorcios.personaId2", "=", idPersona1)
                .Join("Propuestas", "Propuestas.id", "TramiteDivorcios.propuestaId")
                .FirstOrDefault<RegistroDeConsultaDto>();

            if (tramite != null)
            {
                return new RegistroDeConsultaDto
                {
                    actaMatrimonioId = tramite.actaMatrimonioId,
                    idPersona1 = tramite.idPersona1,
                    idPersona2 = tramite.idPersona2,
                    propuesta = tramite.propuesta,
                    fecha = tramite.fecha

                };
            }
            else
            {
                return null;
            }
        }

    }
}
