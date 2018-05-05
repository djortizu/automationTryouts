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
        [FindsBy(How = How.Id, Using = "")]
        public IWebElement GBHLogo { get; set; }

        [WaitForThisElement]
        [FindsBy(How = How.Id, Using = "")]
        public IWebElement Inicio { get; set; }

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement Servicios { get; set; }

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement Portafolio { get; set; }

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement Conocenos { get; set; }

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement Empleos { get; set; }

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement Blog { get; set; }

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
