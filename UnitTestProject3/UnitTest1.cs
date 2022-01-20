using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Sign_IN") ,TestCategory("Positive")]


        public void Loginwithvaliduser_nameandpassword_TC_01()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url="http://automationpractice.com/index.php";
            Thread.Sleep(10000);
            //driver.FindElement(By.ClassName("login")).Click();
           
            driver.FindElement(By.ClassName("login")).Click();
            driver.FindElement(By.Id("email")).SendKeys("Zarmeenkashif@gmail.com");
            driver.FindElement(By.Id("passwd")).SendKeys("zarmeen123");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(10000);
            string actual_result= driver.FindElement(By.XPath("//span[contains(text(),'Zarmeen Kashif')]")).Text;
            Assert.AreEqual("Zarmeen Kashif", actual_result);
            Console.WriteLine("Login successfully");
            driver.Close();
        }

       [TestMethod]
        [TestCategory("Sign_IN"), TestCategory("Negative")]
        public void LoginwithInValid_usernameandInvalid_password_TC_02()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://automationpractice.com/index.php";
            Thread.Sleep(10000);
            driver.FindElement(By.ClassName("login")).Click();
            driver.FindElement(By.Id("email")).SendKeys("asdfg");
            driver.FindElement(By.Id("passwd")).SendKeys("1234");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(10000);
            //string actual_result = driver.FindElement(By.ClassName("alert alert-danger")).Text;
            //Assert.AreEqual("There is 1 error", actual_result);
            driver.Close();
        }

     /*   [TestMethod]
        [TestCategory("Sign_IN"), TestCategory("Positive and Negative")]
        [DataRow("zarmeenkashif@gmail.com","zarmeen123", "//span[contains(text(),'Zarmeen Kashif')", "Zarmeen Kashif")]
        [DataRow("asdfg","1234", "alert alert-danger", "There is 1 error")]
        public void PositiveAndNegative(string user_name,string password, string locator,string expectedMessage)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "http://automationpractice.com/index.php";
            Thread.Sleep(10000);
            driver.FindElement(By.ClassName("login")).Click();
            driver.FindElement(By.Id("email")).SendKeys("user_name");
            driver.FindElement(By.Id("passwd")).SendKeys("password");
            driver.FindElement(By.Id("SubmitLogin")).Click();
            Thread.Sleep(10000);
            string actual_result = driver.FindElement(By.ClassName("alert alert-danger")).Text;
            Assert.AreEqual("There is 1 error", actual_result);
            driver.Close();
        }
     */








    }
}
