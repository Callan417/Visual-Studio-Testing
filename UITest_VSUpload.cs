using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    [TestClass]
    public class UITest_VSUpload
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;


        public UITest_VSUpload()
        {
        }


        [TestMethod]
        [TestCategory("Chrome")]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl(appURL + "/");

            driver.Manage().Window.Maximize();

            IWebElement element_id = driver.FindElement(By.Id("lblName"));

            _ = driver.FindElement(By.Id("lblLocation"));
            _ = driver.FindElement(By.Id("lblPL"));
            _ = driver.FindElement(By.Id("lblAddress"));
            _ = driver.FindElement(By.Id("btnSubmit"));
            _ = driver.FindElement(By.Id("txtName"));
            _ = driver.FindElement(By.Id("txtAddress"));
            _ = driver.FindElement(By.Id("lstPL"));
            _ = driver.FindElement(By.Id("lstLocation"));
            _ = driver.FindElement(By.Id("lblName"));

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

            string browser = "Chrome";
            switch (browser)
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
