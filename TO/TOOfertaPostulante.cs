using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOOfertaPostulante
    {
        public long inId { get; set; }
        public long? inidOfertaLaboral { get; set; }
        public long? inIdPostulante { get; set; }
        public long? inIdEstado { get; set; }
        public decimal? deSalarioOferta { get; set; }
        public char? chSincronizado { get; set; }
        public long? inIdPosicion { get; set; }
        public long? inIdMedioDifusion { get; set; }
        public string vcsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        public TOOfertaPostulante()
        {
            this.inId = 0;
            this.inidOfertaLaboral = 0;
            this.inIdPostulante = 0;
            this.inIdEstado = 0;
            this.deSalarioOferta = 0;
            this.chSincronizado = ' ';
            this.inIdPosicion = 0;
            this.inIdMedioDifusion = 0;
            this.vcsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }

}
