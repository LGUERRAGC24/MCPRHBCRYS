using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOEtapa
    {
        public int inEtapa { get; set; }
        public string vcNombreEtapa { get; set; }
        public string vcDescripcion { get; set; }
        public string vcCodigoEtapa { get; set; }
        public int inOrden { get; set; }
        public string vcUsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        // Constructor por defecto
        public TOEtapa()
        {
            this.inEtapa = 0;
            this.vcNombreEtapa = string.Empty;
            this.vcDescripcion = string.Empty;
            this.vcCodigoEtapa = string.Empty;
            this.inOrden = 0;
            this.vcUsuarioCrea = string.Empty;
            this.vcUsuarioModifica = string.Empty;
            this.dtFechaRegistro = string.Empty;
            this.dtFechaModificacion = string.Empty;
        }
    }

}
