using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    public class BaseSetup
    {
        public IWebDriver driver;
        public void Initialise()
        {
            driver = new ChromeDriver("C:\\CDS_API\\Machining Cloud\\chromedriver_win32");
            driver.Navigate().GoToUrl("https://www.machiningcloud.com/app/en");
        }
        
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
