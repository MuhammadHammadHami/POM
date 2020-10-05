using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.ComponentModel.DataAnnotations;
/*[assembly: Parallelize(Workers = 5, Scope =ExecutionScope.MethodLevel) ]*/
namespace Page_Object_Model_1
{
    [TestClass]
    public class ExecutionClass
    {
        LoginPage loginpage = new LoginPage();
        BasePage basepage = new BasePage();

        #region Execution Hierarchy

        [TestInitialize()]
        public void Initialize()
        {
            basepage.SeleniumInit(); 
        }

        [TestCleanup()]
        public void Cleanup()
        {
            BasePage.driver.Close();
            BasePage.driver.Quit();
            BasePage.driver.Dispose();
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
             
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }
        

        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {

        }

        
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            
        }

        #endregion


        [TestMethod]
        public void TestCase_001()
        {
            
            loginpage.login("http://adactinhotelapp.com", "AmirTester", "AmirTester");
            
        }
        [TestMethod]
        public void TestCase_002()
        {

            loginpage.login("http://adactinhotelapp.com", "AmirTester", "AmirTester");

        }

        [TestMethod]
        public void TestCase_003()
        {

            loginpage.login("http://adactinhotelapp.com", "AmirTester", "AmirTester");

        }


    }
}
