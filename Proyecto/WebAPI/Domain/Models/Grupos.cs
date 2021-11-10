using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class Grupos
    {
        public Grupos()
        {
            GruposAplicaciones = new HashSet<GruposAplicaciones>();
            GruposContenidos = new HashSet<GruposContenidos>();
        }

        public int GrupoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }

        public virtual ICollection<GruposAplicaciones> GruposAplicaciones { get; set; }
        public virtual ICollection<GruposContenidos> GruposContenidos { get; set; }
    }
}
