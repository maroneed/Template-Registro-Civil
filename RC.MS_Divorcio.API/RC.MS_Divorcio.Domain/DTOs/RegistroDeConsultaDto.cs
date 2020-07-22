using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_Divorcio.Domain.DTOs
{
    public class RegistroDeConsultaDto
    {
        
        public int idPersona1 { get; set; }
        public int idPersona2 { get; set; }
        public int actaMatrimonioId { get; set; }
        public string propuesta { get; set; }
        public DateTime fecha { get; set; }
        

    }
}
