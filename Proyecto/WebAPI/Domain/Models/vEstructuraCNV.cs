using System;
using System.Collections.Generic;

#nullable disable

namespace Persistence
{
    public partial class vEstructuraCNV
    {
        public int? ID { get; set; }
        public string Descripcion { get; set; }
        public int? Level { get; set; }
        public int? IDPadre { get; set; }
    }
}
