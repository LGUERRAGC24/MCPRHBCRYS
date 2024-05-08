using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOTipoProceso
    {
        public int inTipoProceso { get; set; }
        public string vcNombreTipoProceso { get; set; }
        public string vcDescripcion { get; set; }
        public string vcCodigoTipoProceso { get; set; }
        public string vcAreaResponsable { get; set; }
        public int? inDuracionEstimada { get; set; }
        public string vcIndicadores { get; set; }
        public string vcRequisitos { get; set; }
        public string vcsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        public TOTipoProceso()
        {
            this.inTipoProceso = 0;
            this.vcNombreTipoProceso = string.Empty;
            this.vcDescripcion = string.Empty;
            this.vcCodigoTipoProceso = string.Empty;
            this.vcAreaResponsable = string.Empty;
            this.inDuracionEstimada = 0;
            this.vcIndicadores = string.Empty;
            this.vcRequisitos = string.Empty;
            this.vcsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }




}


