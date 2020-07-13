using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_Divorcio.Domain.DTOs
{
    public class RegistroTramiteDto
    {
        public int provinciaId { get; set; }
        public int localidadId { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public int idPersona1 { get; set; }
        public int idPersona2 { get; set; }
        public int actaMatrimonioId { get; set; }
        public string propuesta { get; set; }
        public int solicitudTipoId { get; set; }

        




    }
}
