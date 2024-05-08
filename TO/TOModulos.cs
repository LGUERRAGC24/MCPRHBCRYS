using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCPRHBCRYS.TO
{
    public class TOModulos
    {
        public int InIdModulo { get; set; }
        public string VcNombreModulo { get; set; }
        public long? InIdPersonalRegistro { get; set; }
        public DateTime? DtRegistro { get; set; }
        public long? InIdPersonalActualizo { get; set; }
        public DateTime? DtActualizo { get; set; }
        public int? InIdRol { get; set; }

        public TOModulos()
        {
            this.InIdModulo = 0;
            this.VcNombreModulo = string.Empty;
            this.InIdPersonalRegistro = null;
            this.DtRegistro = DateTime.Today;
            this.InIdPersonalActualizo = null;
            this.DtActualizo = null;
            this.InIdRol = null;
        }
    }

}
