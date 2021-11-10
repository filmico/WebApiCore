using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class ContenidosArchivos
    {
        public int ContenidoArchivoId { get; set; }
        public int? ArchivoId { get; set; }
        public int? ContenidoId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }

        public virtual Archivos Archivo { get; set; }
        public virtual Contenidos Contenido { get; set; }
    }
}
