using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class ContenidosLog
    {
        public int IdLog { get; set; }
        public int? ContenidoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid? Hash { get; set; }
        public string Link { get; set; }
        public int? PadreId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }
    }
}
