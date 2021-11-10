using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class Colores
    {
        public Colores()
        {
            GruposAplicaciones = new HashSet<GruposAplicaciones>();
            GruposContenidos = new HashSet<GruposContenidos>();
        }

        public int ColorId { get; set; }
        public string Nombre { get; set; }
        public int? R { get; set; }
        public int? G { get; set; }
        public int? B { get; set; }
        public int? A { get; set; }
        public string Hexa { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }

        public virtual ICollection<GruposAplicaciones> GruposAplicaciones { get; set; }
        public virtual ICollection<GruposContenidos> GruposContenidos { get; set; }
    }
}
