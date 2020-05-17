using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_Divorcio.Domain.Entities
{
    public class TramiteDivorcio
    {
        public int Id { get; set; }
        public int personaId1 { get; set; }
        public int personaId2 { get; set; }
        public int actaMatrimonioId { get; set; }
        public int domicilioConyugalId { get; set; }
        public int propuestaId { get; set; }
        public int detalleHijosId { get; set; }
        public DateTime fecha { get; set; }
        public DomicilioConvivencia domicilioConyugal { get; set; }
        public Propuesta propuesta { get; set; }
        public DetalleHijos detalleHijos { get; set; }
        public SolicitudTipo solicitudTipo { get; set; }

    }
}
