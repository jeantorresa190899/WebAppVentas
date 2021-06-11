using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbAbastecimiento
    {
        public string CodPrv { get; set; }
        public string CodPro { get; set; }
        public decimal PreAba { get; set; }

        public virtual TbProducto CodProNavigation { get; set; }
        public virtual TbProveedor CodPrvNavigation { get; set; }
    }
}
