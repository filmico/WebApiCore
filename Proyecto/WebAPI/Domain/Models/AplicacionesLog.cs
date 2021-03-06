using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class AplicacionesLog
    {
        public int IdLog { get; set; }
        public int AplicacionId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Link { get; set; }
        public int? Orden { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }
    }
}
