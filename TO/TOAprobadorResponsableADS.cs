using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    class TOAprobadorResponsableADS
    {

       
            #region Propiedades

            public string InId { get; set; }

            public string InIdADS { get; set; }

            public string InIdProceso { get; set; }

            public string InIdPaso { get; set; }

            public string InIdPerfilPuesto { get; set; }

            public string InIdPersonal { get; set; }

            public string VcActualizacionPaso { get; set; }

            public string ChUltimoActualizador { get; set; }

            public string vcUsuarioCrea   { get; set; }

            public string VcUsuarioModifica { get; set; }

            public string dtFechaRegistro { get; set; }

            public string dtFechaModificacion { get; set; }

            #endregion

            #region Constructor

            public TOAprobadorResponsableADS()
                    {
                this.InId = string.Empty;
                this.InIdADS = string.Empty;
                this.InIdProceso = string.Empty;
                this.InIdPaso = string.Empty;
                this.InIdPerfilPuesto = string.Empty;
                this.InIdPersonal = string.Empty;
                this.VcActualizacionPaso = string.Empty;
                this.ChUltimoActualizador = string.Empty;
                this.vcUsuarioCrea = string.Empty;
                this.VcUsuarioModifica = string.Empty;
                this.dtFechaRegistro = string.Empty;
                this.dtFechaModificacion = string.Empty;
            }

            #endregion
        }



    }
