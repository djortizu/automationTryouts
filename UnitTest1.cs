using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenio.Extensions;
using Selenio.Tests.MsTest.SUT;
using static Selenio.Tests.MsTest.SUT.App;

namespace Selenio.Tests.MsTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1 : MasterTestClass
    { 
    
        [TestMethod]
        public void TestMethod1()
        {
            RunTest(() =>
            {
                GBHHome.Open();

                App.Reporter.TestStep = "Hacer click en la opcion 'Inicio'";
                GBHHome.Inicio.Click();
                GBHHome.WaitForScreen();

                App.Reporter.TestStep = "Hacer mouse over para desplegar menu en la opcion 'Servicios'";
                GBHHome.HoverOverMenuItem(GBHHome.DesarrolloDeSoftware).DesarrolloDeSoftware.Click();

                App.Reporter.TestStep = "Hacer click en la opcion 'Portafolio'";
                GBHHome.Portafolio.Click();
                GBHHome.WaitForScreen(element: GBHHome.Portafolio);

                App.Reporter.TestStep = "Hacer click en la opcion 'Conocenos'";
                GBHHome.Conocenos.Click();
                GBHHome.WaitForScreen(element: GBHHome.Conocenos);

                App.Reporter.TestStep = "Hacer click en la opcion 'Empleos'";
                GBHHome.Empleos.Click();
                GBHHome.WaitForScreen(element: GBHHome.Empleos);

                App.Reporter.TestStep = "Hacer click en la opcion 'Blog'";
                GBHHome.Blog.Click();
                GBHHome.WaitForScreen(element: GBHHome.Blog);
            });
        }
    }
}
