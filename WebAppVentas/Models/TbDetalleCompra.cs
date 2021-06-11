using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbDetalleCompra
    {
        public string NumOco { get; set; }
        public string CodPro { get; set; }
        public int CanPed { get; set; }

        public virtual TbProducto CodProNavigation { get; set; }
        public virtual TbOrdenCompra NumOcoNavigation { get; set; }
    }
}
