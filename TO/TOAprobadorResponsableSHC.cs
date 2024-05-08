using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOAprobadorResponsableSHC
    {
        #region Campos

        public string InIdAprobadorRespHC { get; set; }

        public string InIdSolicitud { get; set; }

        public string InIdTipoSolicitud { get; set; }

        public string InIdEstadoSolicitud { get; set; }

        public string InIdPaso { get; set; }

        public string InIdPosicion { get; set; }

        public string InIdPersonal { get; set; }

        public string InIdEstadoAprobacion { get; set; }

        public string DtActualizacionPaso { get; set; }

        public string ChUltimoActualizador { get; set; }

        public string vcUsuarioCrea { get; set; }

        public string VcUsuarioModifica { get; set; }

        public string DtFechaRegistro { get; set; }

        public string DtFechaModificacion { get; set; }

    #endregion

    #region Constructor

    
    public TOAprobadorResponsableSHC()
        {
            this.InIdAprobadorRespHC = string.Empty;
            this.InIdSolicitud = string.Empty;
            this.InIdTipoSolicitud = string.Empty;
            this.InIdEstadoSolicitud = string.Empty;
            this.InIdPaso = string.Empty;
            this.InIdPosicion = string.Empty;
            this.InIdPersonal = string.Empty;
            this.InIdEstadoAprobacion = string.Empty;
            this.DtActualizacionPaso = string.Empty;
            this.ChUltimoActualizador = string.Empty;
            this.vcUsuarioCrea = string.Empty;
            this.VcUsuarioModifica = string.Empty;
            this.DtFechaRegistro = string.Empty;
            this.DtFechaModificacion = string.Empty;
        }

        #endregion
    }


}
