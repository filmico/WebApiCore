using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class VPersonalInfo
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public int? Legajo { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string ApellidoyNombre { get; set; }
        public string CUIL { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Funcion { get; set; }
        public Guid? hashArchivo { get; set; }
        public int SectorId { get; set; }
        public string Sector { get; set; }
        public int? PadreId { get; set; }
        public string SectorDependeDe { get; set; }
        public int UbicacionId { get; set; }
        public string Ubicacion { get; set; }
        public int EstadoId { get; set; }
        public string PrefijoEstado { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public int? MarcaUso { get; set; }
    }
}
