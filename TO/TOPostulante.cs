using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOPostulante
    {
        #region Propiedades

        public long inPostulanteRS { get; set; }
        public string vcApellidoPaterno { get; set; }
        public string vcApellidoMaterno { get; set; }
        public string vcPrimerNombre { get; set; }
        public string vcSegundoNombre { get; set; }
        public string dtFechaNacimiento { get; set; }
        public int? inGenero { get; set; }
        public int inEstadoCivil { get; set; }
        public int inTipoDocumento { get; set; }
        public string vcNumeroDocumento { get; set; }
        public int inPaisNacimiento { get; set; }
        public string vcTelefonoCasa { get; set; }
        public string vcTelefonoCelular { get; set; }
        public int inGradoAcademico { get; set; }
        public int inNivelAlcanzado { get; set; }
        public int? inEspecialidad { get; set; }
        public string vcRegion { get; set; }
        public string vcProvincia { get; set; }
        public string vcDistrito { get; set; }
        public int? inTipoVia { get; set; }
        public string vcNombreVia { get; set; }
        public int? inTipoZona { get; set; }
        public string vcNombreZona { get; set; }
        public string vcNumero { get; set; }
        public string vcInterior { get; set; }
        public string vcLote { get; set; }
        public string vcManzana { get; set; }
        public string vcDpto { get; set; }
        public string vcBlock { get; set; }
        public string vcContactoEmergencia { get; set; }
        public int? inRelacionContacto { get; set; }
        public string vcTelefonoContacto { get; set; }
        public string chEsColegiado { get; set; }
        public string vcColegiatura { get; set; }
        public string vcLugarNacimiento { get; set; }
        public int? inProcesoActivo { get; set; }
        public string vcEmail { get; set; }
        public string vcContrasenia { get; set; }
        public int? inIdPersonal { get; set; }
        public string vcsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        #endregion

        #region Constructor por defecto

        public TOPostulante()
        {
            this.inPostulanteRS = 0;
            this.vcApellidoPaterno = string.Empty;
            this.vcApellidoMaterno = string.Empty;
            this.vcPrimerNombre = string.Empty;
            this.vcSegundoNombre = string.Empty;
            this.dtFechaNacimiento = string.Empty;
            this.inGenero = null;
            this.inEstadoCivil = 0;
            this.inTipoDocumento = 0;
            this.vcNumeroDocumento = string.Empty;
            this.inPaisNacimiento = 0;
            this.vcTelefonoCasa = string.Empty;
            this.vcTelefonoCelular = string.Empty;
            this.inGradoAcademico = 0;
            this.inNivelAlcanzado = 0;
            this.inEspecialidad = null;
            this.vcRegion = string.Empty;
            this.vcProvincia = string.Empty;
            this.vcDistrito = string.Empty;
            this.inTipoVia = null;
            this.vcNombreVia = string.Empty;
            this.inTipoZona = null;
            this.vcNombreZona = string.Empty;
            this.vcNumero = string.Empty;
            this.vcInterior = string.Empty;
            this.vcLote = string.Empty;
            this.vcManzana = string.Empty;
            this.vcDpto = string.Empty;
            this.vcBlock = string.Empty;
            this.vcContactoEmergencia = string.Empty;
            this.inRelacionContacto = null;
            this.vcTelefonoContacto = string.Empty;
            this.chEsColegiado = string.Empty;
            this.vcColegiatura = string.Empty;
            this.vcLugarNacimiento = string.Empty;
            this.inProcesoActivo = 0;
            this.vcEmail = string.Empty;
            this.vcContrasenia = string.Empty;
            this.inIdPersonal = 0;

            this.vcsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;

        }

    }
    #endregion
}
