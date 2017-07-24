using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public interface IVentaController
    {
        void Create(VentaDTO venta_dto);

        VentaDTO Read(long id);

        IList<VentaDTO> ReadAll();

        void Update(VentaDTO venta_dto);

        void Delete(long id);
    }
}
