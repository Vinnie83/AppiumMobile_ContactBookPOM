using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumMobileTests.POM
{
    public class ConnectionPage :BasePage
    {
        public ConnectionPage(AndroidDriver<AndroidElement> driver) : base(driver) 
        {
        
        }  

        public void ConnectToUrl(string url = "https://contactbook.velio4ka.repl.co/api")
        {

            var inputSearchField = this.driver.FindElementById("contactbook.androidclient:id/editTextApiUrl");
            inputSearchField.Clear();
            inputSearchField.SendKeys(url);

            var buttonConnect = this.driver.FindElementById("contactbook.androidclient:id/buttonConnect");
            buttonConnect.Click();  

        }

    }
}
