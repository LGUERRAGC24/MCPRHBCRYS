using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOTipoProcesoEtapa
    {
        public int? inTipoProceso { get; set; }
        public int? inEtapa { get; set; }
        public string dtFechaAsignacion { get; set; }
        public string vcsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        public TOTipoProcesoEtapa()
        {
            this.inTipoProceso = 0;
            this.inEtapa = 0;
            this.dtFechaAsignacion = string.Empty;
            this.vcsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }

}



