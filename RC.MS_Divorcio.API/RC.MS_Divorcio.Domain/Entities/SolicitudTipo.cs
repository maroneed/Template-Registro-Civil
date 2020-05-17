using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_Divorcio.Domain.Entities
{
    public class SolicitudTipo
    {
        public int Id { get; set; }
        public string descripcion { get; set; }
        public decimal valor { get; set; }
    }
}
