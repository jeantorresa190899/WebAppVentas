using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVentas.Models.Interface;

namespace WebAppVentas.Models.Repository
{
    public class ProveedorRepository : IProveedorRepository
    {
        ColegioContext db = new ColegioContext();

        public void Add(TbProveedor tbProveedor)
        {
           
        }

        public IEnumerable<TbProveedor> GetAllProveedores()
        {
            return db.TbProveedors;
        }
    }
}
