using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public interface IVentaService
    {
        void Create(Venta venta);

        Venta Read(long id);

        IList<Venta> ReadAll();

        void Update(Venta venta);

        void Delete(long id);
    }
}
