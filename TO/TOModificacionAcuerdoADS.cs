using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOModificacionAcuerdoADS
    {
        #region Campos

        public long InId { get; set; }

        public long InIdADS { get; set; }

        public string DtFecModificaAcuerdo { get; set; }

        public string DtNuevaFachaEntrega { get; set; }

        public string VcObservaciones { get; set; }

        public string ChVBClienteInterno { get; set; }

        public long IdPersonalVBCienteInterno { get; set; }

        public string ChVBRyS { get; set; }

        public long InIdPersonalVBRS { get; set; }

        public byte[] VbArchivoEvidencia { get; set; }

        public string VcNombreArchivoEvidencia { get; set; }

        public string VcUsuarioCrea { get; set; }

        public string VcUsuarioModifica { get; set; }

        public string DtFechaRegistro { get; set; }

        public string DtFechaModificacion { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor por defecto para la clase TOModificacionAcuerdoADS
        /// </summary>
        public TOModificacionAcuerdoADS()
        {
            this.InId = 0;
            this.InIdADS = 0;
            this.DtFecModificaAcuerdo = string.Empty;
            this.DtNuevaFachaEntrega = string.Empty;
            this.VcObservaciones = string.Empty;
            this.ChVBClienteInterno = string.Empty;
            this.IdPersonalVBCienteInterno = 0;
            this.ChVBRyS = string.Empty; 
            this.InIdPersonalVBRS = 0;
            this.VbArchivoEvidencia = null;
            this.VcNombreArchivoEvidencia = string.Empty;
            this.VcUsuarioCrea = string.Empty;
            this.VcUsuarioModifica = string.Empty;
            this.DtFechaRegistro = string.Empty;
            this.DtFechaModificacion = string.Empty;
        }

        #endregion
    }

}
