using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class GruposAplicacionesLog
    {
        public int IdLog { get; set; }
        public int? Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? GrupoId { get; set; }
        public int? AplicacionId { get; set; }
        public int? ColorId { get; set; }
        public int? IconoId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }
    }
}
