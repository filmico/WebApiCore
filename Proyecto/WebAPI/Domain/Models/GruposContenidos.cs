using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class GruposContenidos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? GrupoId { get; set; }
        public int? ContenidoId { get; set; }
        public int? ColorId { get; set; }
        public int? IconoId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }

        public virtual Colores Color { get; set; }
        public virtual Contenidos Contenido { get; set; }
        public virtual Grupos Grupo { get; set; }
        public virtual Iconos Icono { get; set; }
    }
}
