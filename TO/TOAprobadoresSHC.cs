using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOAprobadoresSHC
    {
        #region Campos

        public string InIdAprobadoresHC { get; set; }

        public string InIdSolicitudHC { get; set; }

        public string InIdPaso { get; set; }

        public string InIdPersonal { get; set; }

        public string InIdEstadoAprobacion { get; set; }

        public string InTipoSolicitante { get; set; }

        public string InOrden { get; set; }

        public string VcMotivo { get; set; }

        public string VcsuarioCrea { get; set; }

        public string VcUsuarioModifica { get; set; }

        public string DtFechaRegistro { get; set; }

        public string DtFechaModificacion { get; set; }

        #endregion

        #region Constructor

        public TOAprobadoresSHC()
        {
            this.InIdAprobadoresHC = string.Empty;
            this.InIdSolicitudHC = string.Empty;
            this.InIdPaso = string.Empty;
            this.InIdPersonal = string.Empty;
            this.InIdEstadoAprobacion = string.Empty;
            this.InTipoSolicitante = string.Empty;
            this.InOrden = string.Empty;
           this.VcMotivo = string.Empty;
            this.VcsuarioCrea = string.Empty;
            this.VcUsuarioModifica = string.Empty;
            this.DtFechaRegistro = string.Empty;
            this.DtFechaModificacion = string.Empty;
        }

        #endregion
    }

}
