using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class Estados
    {
        public int EstadoId { get; set; }
        public string Prefijo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }
    }
}
