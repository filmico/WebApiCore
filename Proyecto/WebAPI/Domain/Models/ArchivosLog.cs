using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class ArchivosLog
    {
        public int IdLog { get; set; }
        public int? ArchivoId { get; set; }
        public string Nombre { get; set; }
        public int? Tamano { get; set; }
        public string TipoContenido { get; set; }
        public byte[] Contenido { get; set; }
        public string Extension { get; set; }
        public Guid? Hash { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }
    }
}
