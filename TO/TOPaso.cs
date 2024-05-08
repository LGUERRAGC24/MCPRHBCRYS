using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class TOPaso
{
    public long inId { get; set; }
    public long? inidProceso { get; set; }
    public string vcNombre { get; set; }
    public string vcDescripcion { get; set; }
    public long? inidSubtiposSolicitud { get; set; }
    public int? inInPosicionOrden { get; set; }
    public string vcFormularioUrl { get; set; }
    public int? inNumeroIntentos { get; set; }
    public string vcsuarioCrea { get; set; }
    public string vcUsuarioModifica { get; set; }
    public string dtFechaRegistro { get; set; }
    public string dtFechaModificacion { get; set; }

    public TOPaso()
    {
        this.inId = 0;
        this.inidProceso = 0;
        this.vcNombre = string.Empty;
        this.vcDescripcion = string.Empty;
        this.inidSubtiposSolicitud = 0;
        this.inInPosicionOrden = 0;
        this.vcFormularioUrl = string.Empty;
        this.inNumeroIntentos = 0;
        this.vcsuarioCrea = string.Empty;
        this.vcUsuarioModifica = string.Empty;
        this.dtFechaRegistro = string.Empty;
        this.dtFechaModificacion = string.Empty;
    }
}

