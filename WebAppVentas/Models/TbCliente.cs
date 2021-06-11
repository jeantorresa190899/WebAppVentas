using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbFacturas = new HashSet<TbFactura>();
        }

        public string CodCli { get; set; }
        public string RazSocCli { get; set; }
        public string DirCli { get; set; }
        public string TlfCli { get; set; }
        public string RucCli { get; set; }
        public string CodDis { get; set; }
        public DateTime FecReg { get; set; }
        public string TipCli { get; set; }
        public string Contacto { get; set; }

        public virtual TbDistrito CodDisNavigation { get; set; }
        public virtual ICollection<TbFactura> TbFacturas { get; set; }
    }
}
