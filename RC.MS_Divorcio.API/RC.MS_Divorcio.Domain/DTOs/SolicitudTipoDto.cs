using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_Divorcio.Domain.DTOs
{
    public class SolicitudTipoDto
    {
        public int Id { get; set; }
        public string descripcion { get; set; }
        public decimal valor { get; set; }
    }
}
