using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppVentas.Models.Interface
{
    public interface IDistritoRepository
    {
        //Llamo y defino el metodo para traer los datos de la tbDistrito
        IEnumerable<TbDistrito> GetAllDistritos(); 

        // Metodos de mantenimiento (CRUD)
        void Add(TbDistrito tbDistrito);
        void Remove(string cod);
        TbDistrito Edit(string cod); //Coge el valor y devuelve el objeto
        void EditDetails(TbDistrito tbDistrito);
    }
}
