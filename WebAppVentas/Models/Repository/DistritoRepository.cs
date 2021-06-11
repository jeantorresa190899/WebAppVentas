using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVentas.Models.Interface;

namespace WebAppVentas.Models.Repository
{
    public class DistritoRepository : IDistritoRepository
    {
        ColegioContext db = new ColegioContext();
        public void Add(TbDistrito tbDistrito)
        {
            try
            {
                db.TbDistritos.Add(tbDistrito);
                db.SaveChanges(); // Actualizar la tabla
            }
            catch (Exception e){
                Console.Write(e.Message);
            }
        }

        public TbDistrito Edit(string cod)
        {
            var obj = (from d in db.TbDistritos
                       where d.CodDis == cod
                       select d).Single();
            return obj;
        }

        public void EditDetails(TbDistrito tbDistrito)
        {
            var obj = (from d in db.TbDistritos
                       where d.CodDis == tbDistrito.CodDis
                       select d).FirstOrDefault();
            obj.NomDis = tbDistrito.NomDis;
            db.SaveChanges();
        }

        public IEnumerable<TbDistrito> GetAllDistritos()
        {
            return db.TbDistritos;
        }

        public void Remove(string cod)
        {
            var obj = (from d in db.TbDistritos
                       where d.CodDis == cod 
                       select d).Single();
            db.TbDistritos.Remove(obj); //Eliminar el objeto
            db.SaveChanges(); //Actualizan los cambios
        }
    }
}
