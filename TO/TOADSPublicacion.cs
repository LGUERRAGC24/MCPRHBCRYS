using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    class TOADSPublicacion
    {
       // Propiedades
            public string inId { get; set; }
            public string inIdADS { get; set; }
            public string inIdTipoADS { get; set; }
            public string vcUrl { get; set; }
            public string chPublicado { get; set; }
            public string dtPublicado { get; set; }
            public string dtEjecucion { get; set; }
            public string vcTiempoExRPA { get; set; }
            public string vcExcepcionRPA { get; set; }
            public string vcEtapa { get; set; }
            public string vcEstadoRPA { get; set; }
            public string vcObservacionRPA { get; set; }
            public string chReprocesarRPA { get; set; }
            public string dtInicioVigencia { get; set; }
            public string dtFinVigencia { get; set; }
            public string dtRegistro { get; set; }
            public string vcUsuarioCrea { get; set; }
            public string vcUsuarioModifica { get; set; }
            public string dtFechaRegistro { get; set; }
            public string dtFechaModificacion { get; set; }

    // Constructor por defecto
            public TOADSPublicacion()

            {
                this.inId = string.Empty;
                this.inIdADS = string.Empty;
                this.inIdTipoADS = string.Empty;
                this.vcUrl = string.Empty;
                this.chPublicado = string.Empty;
                this.dtPublicado = string.Empty;
                this.dtEjecucion = string.Empty;
                this.vcTiempoExRPA = string.Empty;
                this.vcExcepcionRPA = string.Empty;
                this.vcEtapa = string.Empty; ;
                this.vcEstadoRPA = string.Empty;
                this.vcObservacionRPA = string.Empty;
                this.chReprocesarRPA = string.Empty;
                this.dtInicioVigencia = string.Empty;
                this.dtFinVigencia = string.Empty;
                this.dtRegistro = string.Empty;
                this.vcUsuarioCrea = string.Empty;
                this.vcUsuarioModifica = string.Empty;
                this.dtFechaRegistro = string.Empty; ;
                this.dtFechaModificacion = string.Empty; ;
            }

        }
    }

