using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOPasoAccion
    {
        public long inId { get; set; }
        public long? inIdPaso { get; set; }
        public long? inIdAccion { get; set; }
        public long? inIdPasoDestino { get; set; }
        public long? inIdPlantillaCorreoSolicitante { get; set; }
        public long? inIdPlantillaCorreoAprobador { get; set; }
        public long? indActivo { get; set; }
        public string vcsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        public TOPasoAccion()
        {
            this.inId = 0;
            this.inIdPaso = 0;
            this.inIdAccion = 0;
            this.inIdPasoDestino = 0;
            this.inIdPlantillaCorreoSolicitante = 0;
            this.inIdPlantillaCorreoAprobador = 0;
            this.indActivo = 0;
            this.vcsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }

}
