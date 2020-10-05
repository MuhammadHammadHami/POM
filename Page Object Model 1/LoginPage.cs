using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static Page_Object_Model_1.ExecutionClass;

namespace Page_Object_Model_1
{
    public class LoginPage : BasePage
    {
        public void login(string url, string username, string password)
        {
            By usernameTXT = By.Id("username");
            By passwordTXT = By.Id("password");
            By loginBTN = By.Id("login");

            driver.Url = url;

            driver.FindElement(usernameTXT).SendKeys(username);
            driver.FindElement(passwordTXT).SendKeys(password);
            driver.FindElement(loginBTN).Click();
            
        }
    }
}
