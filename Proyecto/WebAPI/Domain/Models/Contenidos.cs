using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class Contenidos
    {
        public Contenidos()
        {
            ContenidosArchivos = new HashSet<ContenidosArchivos>();
            GruposContenidos = new HashSet<GruposContenidos>();
        }

        public int ContenidoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid? Hash { get; set; }
        public string Link { get; set; }
        public int? PadreId { get; set; }
        public int? TipoContenidoId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }
        public int? Orden { get; set; }

        public virtual TiposContenido TipoContenido { get; set; }
        public virtual ICollection<ContenidosArchivos> ContenidosArchivos { get; set; }
        public virtual ICollection<GruposContenidos> GruposContenidos { get; set; }
    }
}
