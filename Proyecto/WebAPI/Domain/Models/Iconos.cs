using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class Iconos
    {
        public Iconos()
        {
            GruposAplicaciones = new HashSet<GruposAplicaciones>();
            GruposContenidos = new HashSet<GruposContenidos>();
        }

        public int IconoId { get; set; }
        public string Nombre { get; set; }
        public string Libreria { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }

        public virtual ICollection<GruposAplicaciones> GruposAplicaciones { get; set; }
        public virtual ICollection<GruposContenidos> GruposContenidos { get; set; }
    }
}
