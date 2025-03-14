using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverSearchTest
{
    public class Tests
    {
        //private IWebDriver driver; 

        //[SetUp]
        //public void Setup()
        //{
        //    driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //}

        [Test]
        public void WikipediaSearch()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://wikipedia.org");

            Console.WriteLine("Main page title:" + driver.Title);

            var SearchBox = driver.FindElement(By.Id("searchInput"));

            SearchBox.SendKeys("Quality Assurance" + Keys.Enter);

            Console.WriteLine("Title after search");

            driver.Quit();
        }

        //[TearDown]
        //public void Cleanup()
        //{
        //    driver.Quit();
        //}
    }
}
