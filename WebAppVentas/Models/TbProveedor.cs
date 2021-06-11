using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbProveedor
    {
        public TbProveedor()
        {
            TbAbastecimientos = new HashSet<TbAbastecimiento>();
            TbOrdenCompras = new HashSet<TbOrdenCompra>();
        }

        public string CodPrv { get; set; }
        public string RazSocPrv { get; set; }
        public string DirPrv { get; set; }
        public string TelPrv { get; set; }
        public string CodDis { get; set; }
        public string RepVen { get; set; }

        public virtual TbDistrito CodDisNavigation { get; set; }
        public virtual ICollection<TbAbastecimiento> TbAbastecimientos { get; set; }
        public virtual ICollection<TbOrdenCompra> TbOrdenCompras { get; set; }
    }
}
