using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class TiposContenido
    {
        public TiposContenido()
        {
            Contenidos = new HashSet<Contenidos>();
        }

        public int TipoContenidoId { get; set; }
        public string Nombre { get; set; }
        public string Prefijo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }

        public virtual ICollection<Contenidos> Contenidos { get; set; }
    }
}
