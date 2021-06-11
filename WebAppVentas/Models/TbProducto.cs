using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbProducto
    {
        public TbProducto()
        {
            TbAbastecimientos = new HashSet<TbAbastecimiento>();
            TbDetalleCompras = new HashSet<TbDetalleCompra>();
            TbDetalleFacturas = new HashSet<TbDetalleFactura>();
        }

        public string CodPro { get; set; }
        public string DesPro { get; set; }
        public decimal PrePro { get; set; }
        public int StkAct { get; set; }
        public int StkMin { get; set; }
        public string UniMed { get; set; }
        public string LinPro { get; set; }
        public string Importado { get; set; }

        public virtual ICollection<TbAbastecimiento> TbAbastecimientos { get; set; }
        public virtual ICollection<TbDetalleCompra> TbDetalleCompras { get; set; }
        public virtual ICollection<TbDetalleFactura> TbDetalleFacturas { get; set; }
    }
}
