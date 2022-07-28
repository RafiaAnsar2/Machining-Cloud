using OpenQA.Selenium;

namespace NUnitProject.POM
{
    public class HomePage: BaseSetup
    {
        public HomePage(IWebDriver driver)
        {
            this.driver = driver; 
        }

        private string PageUrl = "https://www.machiningcloud.com/app/en";
        private string PageTitle = "MachiningCloud WebApp";

        public void BrowserCatalogClick() => driver.FindElement(By.XPath("//div[contains(text(),'Browse Catalogs')]")).Click();

        public IWebElement Toggle => driver.FindElement(By.XPath("//div/img[@class='unit-toggle-img']"));

        public IWebElement SearchResult => driver.FindElement(By.XPath("//button/img[@alt='Iscar']"));
        public IWebElement SearchCatalog=> driver.FindElement(By.Id("searchTextBox"));
        

        public void ChooseManufacturer()
        {
            SearchCatalog.SendKeys("Israc");
            SearchResult.Click();
        }

        public void DismissFrame()
        {
            //IWebElement frame=driver.FindElement(By.Id("userpilot-builder"));
            driver.SwitchTo().Frame(0);
            //driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='popup']//div[text()='Dismiss']")));
            driver.FindElement(By.XPath("//*[@id='popup']//div[text()='Dismiss']")).Click();
            //IJavaScriptExecutor jse= (IJavaScriptExecutor) driver;
            //jse.ExecuteScript("argument[0].click()", dismiss);
            
            driver.SwitchTo().DefaultContent();


        }

        public void SelectToggle()
        {
            Toggle.Click();
        }

        
        public void EnsurePageLoaded()
        {
            bool pageloaded = driver.Url.StartsWith(PageUrl) && (driver.Title == PageTitle);
            if (!pageloaded)
            {
                throw new Exception("Failed to load page.");
            }
           
        }
    }
}
