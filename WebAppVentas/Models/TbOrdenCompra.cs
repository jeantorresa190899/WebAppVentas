using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbOrdenCompra
    {
        public TbOrdenCompra()
        {
            TbDetalleCompras = new HashSet<TbDetalleCompra>();
        }

        public string NumOco { get; set; }
        public DateTime FecOco { get; set; }
        public string CodPrv { get; set; }
        public DateTime FecAte { get; set; }
        public string EstOco { get; set; }

        public virtual TbProveedor CodPrvNavigation { get; set; }
        public virtual ICollection<TbDetalleCompra> TbDetalleCompras { get; set; }
    }
}
