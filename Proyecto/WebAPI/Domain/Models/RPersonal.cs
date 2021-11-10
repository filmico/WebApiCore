using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class RPersonal
    {
        public int Id { get; set; }
        public int? PersonaId { get; set; }
        public int? ArchivoId { get; set; }
        public int? UbicacionId { get; set; }
        public int? SectorId { get; set; }
        public int? EstadoId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }

        public virtual Archivos Archivo { get; set; }
        public virtual Personas Persona { get; set; }
        public virtual Sectores Sector { get; set; }
        public virtual Ubicaciones Ubicacion { get; set; }
    }
}
