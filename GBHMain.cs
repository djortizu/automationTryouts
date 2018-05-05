using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using Selenio.Core.SUT;
using Selenio.Extensions;
using Selenio.Tests.MsTest.SUT;
using static Selenio.Tests.MsTest.SUT.App;

namespace Selenio.Tests.MsTest.PageObjects.GBH
{
    public class GBHMain : PageObject
    {
        [FindsBy(How = How.XPath, Using = "//a[@title='Inicio']")]
        public IWebElement GBHLogo { get; set; }

        [WaitForThisElement]
        [FindsBy(How = How.XPath, Using = "menu-item-21")]
        public IWebElement Inicio { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-209")]
        public IWebElement Servicios { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-62")]
        public IWebElement Portafolio { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-65")]
        public IWebElement Conocenos { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-126")]
        public IWebElement Empleos { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-20")]
        public IWebElement Blog { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-2976")]
        public IWebElement DesarrolloDeSoftware { get; set; }


        public virtual GBHMain Open()
        {
            App.Reporter.TestStep = "Navegar hacia la pagina oficial de GBH.";
            Driver.Url = "http://gbh.com.do/";
            this.WaitForScreen();
            return this;
        }

        public virtual GBHMain HoverOverMenuItem(IWebElement element)
        {
            Actions movement = new Actions(Driver);
            movement.MoveToElement(Servicios).MoveToElement(element).Build();
            return this;
        }
    }
}
