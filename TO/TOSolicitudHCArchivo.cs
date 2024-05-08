using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOSolicitudHCArchivo
    {
        public long inIdSolicitudHCArch { get; set; }
        public long? inIdSolicitudHC { get; set; }
        public byte[] vbArchivo { get; set; }
        public string vcArchivoNombre { get; set; }
        public string vcsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        public TOSolicitudHCArchivo()
        {
            this.inIdSolicitudHCArch = 0;
            this.inIdSolicitudHC = 0;
            this.vbArchivo = null;
            this.vcArchivoNombre = string.Empty;
            this.vcsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }


}
