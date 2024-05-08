using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOADS
    {
        #region Propiedades

        public string InId { get; set; }
        public string InIdADS { get; set; }
        public string InIdSolicitudHC { get; set; }
        public string InIdPerfilPuesto { get; set; }
        public string InIdPuesto { get; set; }
        public string ChCubiertaInternamente { get; set; }
        public string VcCubiertaInternamente { get; set; }
        public string ChCubiertaPorComunidad { get; set; }
        public string VcCubiertaPorComunidad { get; set; }
        public string VcFechaInicio { get; set; }
        public string VcFechaFin { get; set; }
        public string InIdPersonalClienteInterno { get; set; }
        public string InidPersonalGerenteArea { get; set; }
        public string InidPersonalVicepresidenteArea { get; set; }
        public string IndPersonalRegistro { get; set; }
        public string ChActivo { get; set; }
        public string InidEstado { get; set; }
        public string InidVP { get; set; }
        public string InIdDepartamento { get; set; }
        public string ChHabilitarGerente { get; set; }
        public string ChHabilitarVP { get; set; }
        public string InIdTipoADS { get; set; }
        public string VcUsuarioCrea { get; set; }
        public string VcUsuarioModifica { get; set; }
        public string VcFechaRegistro { get; set; }
        public string VcFechaModificacion { get; set; }

        #endregion

        #region Constructor

        public TOADS()
        {
            // Se inicializan las propiedades con valores predeterminados
            this.InId = string.Empty; 
            this.InIdADS = string.Empty; 
            this.InIdSolicitudHC = string.Empty; 
            this.InIdPerfilPuesto = string.Empty; 
            this.InIdPuesto = string.Empty; 
            this.ChCubiertaInternamente = string.Empty;
            this.VcCubiertaInternamente = string.Empty;
            this.ChCubiertaPorComunidad = string.Empty;
            this.VcCubiertaPorComunidad = string.Empty;
            this.VcFechaInicio = string.Empty;
            this.VcFechaFin = string.Empty;
            this.InIdPersonalClienteInterno = string.Empty; 
            this.InidPersonalGerenteArea = string.Empty; 
            this.InidPersonalVicepresidenteArea = string.Empty; 
            this.IndPersonalRegistro = string.Empty;
            this.ChActivo = string.Empty;
            this.InidEstado = string.Empty;
            this.InidVP = string.Empty;
            this.InIdDepartamento = string.Empty;
            this.ChHabilitarGerente = string.Empty;
            this.ChHabilitarVP = string.Empty;
            this.InIdTipoADS = string.Empty;
            this.VcUsuarioCrea = string.Empty;
            this.VcUsuarioModifica = string.Empty;
            this.VcFechaRegistro = string.Empty;
            this.VcFechaModificacion = string.Empty;
        }

       
        #endregion
    }

}