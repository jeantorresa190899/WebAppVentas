using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebAppVentas.Models
{
    public partial class TbDistrito
    {
        public TbDistrito()
        {
            TbClientes = new HashSet<TbCliente>();
            TbProveedors = new HashSet<TbProveedor>();
            TbVendedors = new HashSet<TbVendedor>();
        }
        [Required(ErrorMessage = "El campo ID es obligatorio")]

        public string CodDis { get; set; }
        [Required(ErrorMessage = "El campo NOMBRE es obligatorio")]
        public string NomDis { get; set; }

        public virtual ICollection<TbCliente> TbClientes { get; set; }
        public virtual ICollection<TbProveedor> TbProveedors { get; set; }
        public virtual ICollection<TbVendedor> TbVendedors { get; set; }
    }
}
