using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{

    public class TONotificaciones
    {
        public long inIdNotificacion { get; set; }
        public long? inIdUser { get; set; }
        public int? inTipoNotificacion { get; set; }
        public char? chEstadoNotificacion { get; set; }
        public string dtFechaEnvio { get; set; }
        public long? inIdSolicitudHC { get; set; }
        public long? inIdPersonal { get; set; }
        public string vcEmail { get; set; }
        public string vcAsunto { get; set; }
        public string vcEmailDestino { get; set; }
        public string vcEmailDestinoCC { get; set; }
        public string vcCodigoyNombrePuesto { get; set; }
        public string vcMailMensaje { get; set; }
        public string vcLinkAccesoValidacion { get; set; }
        public string vcArchEvaluacionMedica { get; set; }
        public string vcArchEvalReferenciasLaboral { get; set; }
        public string vcsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }
       
        
    public TONotificaciones()
        {
            this.inIdNotificacion = 0;
            this.inIdUser = 0;
            this.inTipoNotificacion = 0;
            this.chEstadoNotificacion = '\0'; // Valor por defecto para char
            this.dtFechaEnvio = string.Empty;
            this.inIdSolicitudHC = 0;
            this.inIdPersonal = 0;
            this.vcEmail = string.Empty;
            this.vcAsunto = string.Empty;
            this.vcEmailDestino = string.Empty;
            this.vcEmailDestinoCC = string.Empty;
            this.vcCodigoyNombrePuesto = string.Empty;
            this.vcMailMensaje = string.Empty;
            this.vcLinkAccesoValidacion = string.Empty;
            this.vcArchEvaluacionMedica = string.Empty;
            this.vcArchEvalReferenciasLaboral = string.Empty;
            this.vcsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }



}
