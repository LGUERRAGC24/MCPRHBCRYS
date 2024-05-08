using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{

    public class TOAprobadoresADS
    {
        public string inId { get; set; }
        public string inIdADS { get; set; }
        public string inIdPaso { get; set; }
        public string inIdPersonal { get; set; }
        public string inIdEstadoAprobacion { get; set; }
        public string inOrden { get; set; }
        public string vcMotivo { get; set; }
        public string vcUsuarioCrea { get; set; }
        public string vcUsuarioModifica { get; set; }
        public string dtFechaRegistro { get; set; }
        public string dtFechaModificacion { get; set; }

        // Constructor por defecto
        public TOAprobadoresADS()
        {
            inId = string.Empty;
            inIdADS = string.Empty;
            inIdPaso = string.Empty;
            inIdPersonal = string.Empty;
            inIdEstadoAprobacion = string.Empty;
            inOrden = string.Empty;
            vcMotivo = string.Empty;
            vcUsuarioCrea = string.Empty;
            vcUsuarioModifica = string.Empty;
            dtFechaRegistro = string.Empty;
            dtFechaModificacion = string.Empty;
        }
    }



}
