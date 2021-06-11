using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbDetalleFactura
    {
        public string NumFac { get; set; }
        public string CodPro { get; set; }
        public int CanVen { get; set; }
        public decimal PreVen { get; set; }

        public virtual TbProducto CodProNavigation { get; set; }
        public virtual TbFactura NumFacNavigation { get; set; }
    }
}
