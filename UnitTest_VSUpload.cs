using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest_VSUpload
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;
        private string insert_name;
        private string insert_email;
        private string insert_location;
        private string insert_language;

        public UnitTest_VSUpload()
        {
        }


        [TestMethod]
        [TestCategory("Chrome")]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl(appURL + "/");

            driver.Manage().Window.Maximize();


            IWebElement name = driver.FindElement(By.Id("txtName"));

            IWebElement address = driver.FindElement(By.Id("txtAddress"));

            IWebElement planguage = driver.FindElement(By.Id("lstPL"));

            IWebElement submit = driver.FindElement(By.Id("btnSubmit"));

            name.SendKeys(insert_name);

            Task.Delay(1000).Wait();

            address.SendKeys(insert_email);

            Task.Delay(1000).Wait();

            SelectElement location = new SelectElement(driver.FindElement(By.Id("lstLocation")));

            location.SelectByText(insert_location);

            Task.Delay(2000).Wait();

            SelectElement pLanguage = new SelectElement(planguage);
            pLanguage.SelectByText(insert_language);

            Task.Delay(2000).Wait();

            submit.Click();

            Task.Delay(3000).Wait();

           // need to add test for what must happen after submit
           // _ = driver.FindElement(By.XPath("//a[normalize-space() = 'Panda Panda']"));
        }

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize()]
        public void SetupTest()
        {
            appURL = "http://visualstudiouploadtest.eastus.cloudapp.azure.com/";
            insert_name = "Panda Panda";
            insert_email = "flyingpandas@gmail.com";
            insert_location = "Africa";
            insert_language = "Java";

            string browser = "Chrome";
            switch(browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
            }
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }
    }
}
