using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{

    public class TOOfertaLaboral
    {
        public long inId { get; set; }
        public int? inTipoContrato { get; set; }
        public long? inIdTipoContrato { get; set; }
        public int? inLugarTrabajo { get; set; }
        public long? inIdLugarTrabajo { get; set; }
        public string vcCodigoSAP { get; set; }
        public long? inIdPosicion { get; set; }
        public long? inIdPuestoJefe { get; set; }
        public string dtFechaInicio { get; set; }
        public string dtFechaFin { get; set; }
        public int? inRegimenLaboral { get; set; }
        public long? inIdRegimenLaboral { get; set; }
        public int? inTipoManoObra { get; set; }
        public long? inIdTipoManoObra { get; set; }
        public long? inIdCategoriaEmpleado { get; set; }
        public long? inIdVicepresidenciaId { get; set; }
        public long? inIdDepartamento { get; set; }
        public long? inIdSeccion { get; set; }
        public long? inEstado { get; set; }
        public long? inIdEstado { get; set; }
        public decimal? deSalarioBase { get; set; }
        public long? inIdPlantillaCartaOferta { get; set; }
        public string vcAbrOferta { get; set; }
        public long? inIdPuesto { get; set; }
        public long? inIdCampamento { get; set; }
        public long? inIdSolicitudHC { get; set; }
        public long? inIdTipoSolicitudHC { get; set; }
        public string dtFecFinActPerfil { get; set; }
        public string vcsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

   
    public TOOfertaLaboral()
        {
            this.inId = 0;
            this.inTipoContrato = 0;
            this.inIdTipoContrato = 0;
            this.inLugarTrabajo = 0;
            this.inIdLugarTrabajo = 0;
            this.vcCodigoSAP = string.Empty;
            this.inIdPosicion = 0;
            this.inIdPuestoJefe = 0;
            this.dtFechaInicio = string.Empty;
            this.dtFechaFin = string.Empty;
            this.inRegimenLaboral = 0;
            this.inIdRegimenLaboral = 0;
            this.inTipoManoObra = 0;
            this.inIdTipoManoObra = 0;
            this.inIdCategoriaEmpleado = 0;
            this.inIdVicepresidenciaId = 0;
            this.inIdDepartamento = 0;
            this.inIdSeccion = 0;
            this.inEstado = 0;
            this.inIdEstado = 0;
            this.deSalarioBase = 0;
            this.inIdPlantillaCartaOferta = 0;
            this.vcAbrOferta = string.Empty;
            this.inIdPuesto = 0;
            this.inIdCampamento = 0;
            this.inIdSolicitudHC = 0;
            this.inIdTipoSolicitudHC = 0;
            this.dtFecFinActPerfil = string.Empty;
            this.vcsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }



}