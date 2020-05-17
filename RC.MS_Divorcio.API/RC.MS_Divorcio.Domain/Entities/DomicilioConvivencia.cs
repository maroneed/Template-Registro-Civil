using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_Divorcio.Domain.Entities
{
    public class DomicilioConvivencia
    {
        public int Id { get; set; }

        public int provinciaId { get; set; }
        public int localidadId { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
    }
}
