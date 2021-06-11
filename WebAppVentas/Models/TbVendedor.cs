using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbVendedor
    {
        public TbVendedor()
        {
            TbFacturas = new HashSet<TbFactura>();
        }

        public string CodVen { get; set; }
        public string NomVen { get; set; }
        public string ApeVen { get; set; }
        public decimal SueldoVen { get; set; }
        public DateTime FecIng { get; set; }
        public string TipVen { get; set; }
        public string CodDis { get; set; }

        public virtual TbDistrito CodDisNavigation { get; set; }
        public virtual ICollection<TbFactura> TbFacturas { get; set; }
    }
}
