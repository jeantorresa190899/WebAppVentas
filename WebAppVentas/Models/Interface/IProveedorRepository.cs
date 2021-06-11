using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVentas.Models.Interface
{
    public interface IProveedorRepository
    {
        IEnumerable<TbProveedor> GetAllProveedores();
        void Add(TbProveedor tbProveedor);
    }
}
