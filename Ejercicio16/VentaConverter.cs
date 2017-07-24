using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class VentaConverter : IVentaConverter
    {
        public Venta DTOToEntity(VentaDTO venta_dto)
        {
            Venta resultado = new Venta();
            resultado.Id = venta_dto.Id;
            return resultado;
        }

        public VentaDTO EntityToDTO(Venta venta)
        {
            VentaDTO resultado = new VentaDTO();
            resultado.Id = venta.Id;
            return resultado;
        }
    }
}
