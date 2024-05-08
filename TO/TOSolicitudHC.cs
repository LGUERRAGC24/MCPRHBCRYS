using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOSolicitudHC
    {
        public string inIdSolicitudHC { get; set; }
        public string inReferencia { get; set; }
        public string vcReferencia { get; set; }
        public string inIdPersonalSolicitante { get; set; }
        public string inIdPersonalVParea { get; set; }
        public string idPersonalGerenteArea { get; set; }
        public string inTipoSolicitud { get; set; }
        public string inIdPosicion { get; set; }
        public string vcSustento { get; set; }
        public string inCantidadPosiciones { get; set; }
        public string inIdJefeReporta { get; set; }
        public string inIdLugarTrabajo { get; set; }
        public string inIdRegimenTrabajo { get; set; }
        public string inIdTipoContrato { get; set; }
        public string inTiempoContrato { get; set; }
        public string chDeclaracionJurada { get; set; }
        public string inIdEstado { get; set; }
        public string inOrden { get; set; }
        public string inCantAprobadores { get; set; }
        public string chAtipico { get; set; }
        public string dtFecIicioActPerfil { get; set; }
        public string dtFecFinActPerfil { get; set; }
        public string vcPuesto { get; set; }
        public string vcusuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        public TOSolicitudHC()
        {
            this.inIdSolicitudHC = string.Empty;
           this.inReferencia = string.Empty;
           this.vcReferencia = string.Empty;
            this.inIdPersonalSolicitante = string.Empty;
            this.inIdPersonalVParea = string.Empty;
            this.idPersonalGerenteArea = string.Empty;
            this.inTipoSolicitud = string.Empty;
            this.inIdPosicion = string.Empty;
            this.vcSustento = string.Empty;
            this.inCantidadPosiciones = string.Empty;
            this.inIdJefeReporta = string.Empty;
            this.inIdLugarTrabajo = string.Empty;
            this.inIdRegimenTrabajo = string.Empty;
            this.inIdTipoContrato = string.Empty;
            this.inTiempoContrato = string.Empty;
            this.chDeclaracionJurada = string.Empty;
            this.inIdEstado = string.Empty;
            this.inOrden = string.Empty;
            this.inCantAprobadores = string.Empty;
            this.chAtipico = string.Empty;
            this.dtFecIicioActPerfil = string.Empty;
            this.dtFecFinActPerfil = string.Empty;
            this.vcPuesto = string.Empty;
            this.vcusuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }

}
