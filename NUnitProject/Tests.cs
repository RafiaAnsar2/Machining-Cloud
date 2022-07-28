using NUnitProject.POM;

namespace NUnitProject
{
    public class Tests: BaseSetup
    {
        public HomePage home;
        [SetUp]
        public void Setup()
        {
            Initialise();
            home = new HomePage(driver);
        }
        [Test]
        public void VerifyPageLoaded()
        {
            home.EnsurePageLoaded();
        }
        [Test]
        public void VerifyUnitToggle()
        {
            home.DismissFrame();
            Thread.Sleep(10);
            home.BrowserCatalogClick();
            home.ChooseManufacturer();
            home.SelectToggle();
            //Assert.True();
        }

        [TearDown]
        public void TearDown()
        {
           Cleanup();
        }
    }
}