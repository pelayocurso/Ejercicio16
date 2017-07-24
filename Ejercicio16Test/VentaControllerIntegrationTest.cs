using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio16;
using Microsoft.Practices.Unity;

namespace Ejercicio16Test
{
    [TestClass]
    public class VentaControllerIntegrationTest
    {
        private IVentaController venta_controller;

        [TestInitialize]
        public void Initialize()
        {
            IUnityContainer container = new Microsoft.Practices.Unity.UnityContainer();
            container.RegisterType<IVentaRepository, VentaRepository>();
            container.RegisterType<IVentaService, VentaService>();
            container.RegisterType<IVentaConverter, VentaConverter>();
            container.RegisterType<IVentaController, VentaController>();

            venta_controller = container.Resolve<IVentaController>();
        }

        [TestMethod]
        public void TestCreate()
        {
            VentaDTO venta_dto = new VentaDTO();
            venta_controller.Create(venta_dto);
        }
    }
}
