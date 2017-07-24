using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class VentaController : IVentaController
    {
        private IVentaService service;
        private IVentaConverter converter;

        public VentaController (IVentaService service, IVentaConverter converter)
        {
            this.service = service;
            this.converter = converter;
        }

        public void Create(VentaDTO venta_dto)
        {
            Venta venta = converter.DTOToEntity(venta_dto);
            service.Create(venta);
        }

        public void Delete(long id)
        {
            service.Delete(id);
        }

        public VentaDTO Read(long id)
        {
            Venta venta = service.Read(id);
            VentaDTO venta_dto = converter.EntityToDTO(venta);
            return venta_dto;
        }

        public IList<VentaDTO> ReadAll()
        {
            IList<Venta> ventas = service.ReadAll();
            IList<VentaDTO> ventas_dto = new List<VentaDTO>();
            foreach(Venta venta in ventas){
                ventas_dto.Add(converter.EntityToDTO(venta));
            }
            return ventas_dto;
        }

        public void Update(VentaDTO venta_dto)
        {
            throw new NotImplementedException();
        }
    }
}
