using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class PersonasLog
    {
        public int IdLog { get; set; }
        public int? PersonaId { get; set; }
        public int? Legajo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CUIL { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Funcion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioAD { get; set; }
        public bool? MarcaUso { get; set; }
    }
}
