using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace WebDriverSearchTest
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void WikipediaSearch()
        {
            driver.Navigate().GoToUrl("https://wikipedia.org");

            Console.WriteLine("Main page title: " + driver.Title);

            var searchBox = driver.FindElement(By.Id("searchInput"));
            searchBox.SendKeys("Quality Assurance" + Keys.Enter);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.TitleContains("Quality assurance"));

            Console.WriteLine("Title after search: " + driver.Title);

            Assert.That(driver.Title, Does.Contain("Quality assurance"));
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
