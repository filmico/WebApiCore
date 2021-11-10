using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class Ubicaciones
    {
        public Ubicaciones()
        {
            RPersonal = new HashSet<RPersonal>();
        }

        public int UbicacionId { get; set; }
        public string Descripcion { get; set; }
        public int? PadreId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }

        public virtual ICollection<RPersonal> RPersonal { get; set; }
    }
}
