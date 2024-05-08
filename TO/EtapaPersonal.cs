using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOEtapaPersonal
    {
        public int inEtapaPersonal { get; set; }
        public int? inProcesoSeleccion { get; set; }
        public int? inEtapa { get; set; }
        public int? inIdPersonal { get; set; }
        public int? inEstado { get; set; }
        public string vcComentario { get; set; }
        public string vcUsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        public TOEtapaPersonal()
        {
            this.inEtapaPersonal = 0;
            this.inProcesoSeleccion = 0;
            this.inEtapa = 0;
            this.inIdPersonal = 0;
            this.inEstado = 0;
            this.vcComentario = string.Empty;
            this.vcUsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }

}
