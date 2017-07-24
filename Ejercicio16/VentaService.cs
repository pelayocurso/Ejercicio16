using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class VentaService : IVentaService
    {
        private IVentaRepository repository;

        public VentaService(IVentaRepository repository)
        {
            this.repository = repository;
        }

        public void Create(Venta venta)
        {
            repository.Create(venta);
        }

        public void Delete(long id)
        {
            repository.Delete(id);
        }

        public Venta Read(long id)
        {
            return repository.Read(id);
        }

        public IList<Venta> ReadAll()
        {
            return repository.ReadAll();
        }

        public void Update(Venta venta)
        {
            repository.Update(venta);
        }
    }
}
