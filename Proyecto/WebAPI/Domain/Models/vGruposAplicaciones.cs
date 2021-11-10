using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class vGruposAplicaciones
    {
        public int idGrupoApp { get; set; }
        public string NombreGrupoApp { get; set; }
        public string DescripcionGrupoApp { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public int ColorId { get; set; }
        public string Color { get; set; }
        public int? R { get; set; }
        public int? G { get; set; }
        public int? B { get; set; }
        public int? A { get; set; }
        public string Hexa { get; set; }
        public int IconoId { get; set; }
        public string Icono { get; set; }
        public string Libreria { get; set; }
        public int GrupoId { get; set; }
        public string Grupo { get; set; }
        public int AplicacionId { get; set; }
        public string Aplicacion { get; set; }
        public string DescripcionAplicacion { get; set; }
        public string Link { get; set; }
        public int? Orden { get; set; }
    }
}
