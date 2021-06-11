using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbFactura
    {
        public TbFactura()
        {
            TbDetalleFacturas = new HashSet<TbDetalleFactura>();
        }

        public string NumFac { get; set; }
        public DateTime FecFac { get; set; }
        public string CodCli { get; set; }
        public DateTime FecCan { get; set; }
        public string EstFac { get; set; }
        public string CodVen { get; set; }
        public decimal PorcIgv { get; set; }

        public virtual TbCliente CodCliNavigation { get; set; }
        public virtual TbVendedor CodVenNavigation { get; set; }
        public virtual ICollection<TbDetalleFactura> TbDetalleFacturas { get; set; }
    }
}
