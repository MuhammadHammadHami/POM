using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using static Page_Object_Model_1.ExecutionClass;

namespace Page_Object_Model_1
{
    public class BasePage
    {
        public static IWebDriver driver;

        public void SeleniumInit()
        {
            var myDriver = new ChromeDriver();
            driver = myDriver;
        }
    }
}
