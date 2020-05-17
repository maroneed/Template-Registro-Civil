using System;
using System.Collections.Generic;
using System.Text;

namespace RC.MS_Divorcio.Domain.Entities
{
    public class DetalleHijos
    {
        public int Id { get; set; }
        public ICollection<Hijos> hijosNavigator { get; set; }


    }
}
