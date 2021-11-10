using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class GruposLog
    {
        public int IdLog { get; set; }
        public int? GrupoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }
    }
}
