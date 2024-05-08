using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOROLES
    {
        public int inIdRol { get; set; }
        public string vcNombreRol { get; set; }
        public string vcTipoRol { get; set; }
        public char chEstadoRol { get; set; }
        public string vcsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        // Constructor por defecto
        public TOROLES()
        {
            this.inIdRol = 0;
            this.vcNombreRol = string.Empty;
            this.vcTipoRol = string.Empty;
            this.chEstadoRol = '\0'; // Carácter nulo para char
            this.vcsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }
}
