using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_Divorcio.Domain.DTOs
{
    public class TramiteDivorcioDto
    {
        public int Id { get; set; }
        public int personaId1 { get; set; }
        public int personaId2 { get; set; }
        public int actaMatrimonioId { get; set; }
        public int domicilioConyugalId { get; set; }
        public int propuestaId { get; set; }
        public int detalleHijosId { get; set; }
        public DateTime fecha { get; set; }
    }
}
