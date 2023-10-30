using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumMobileTests.POM
{
    public class SearchPage :BasePage
    {
        public SearchPage(AndroidDriver<AndroidElement> driver) : base(driver) 
        { 
        
        }

        public AndroidElement SearchInput => this.driver.FindElementById("contactbook.androidclient:id/editTextKeyword");
        public AndroidElement SearchButton => this.driver.FindElementById("contactbook.androidclient:id/buttonSearch");

        public string GetActualResult()
        {
            var firstName = this.driver.FindElementById("contactbook.androidclient:id/textViewFirstName").Text;
            var lastName = this.driver.FindElementById("contactbook.androidclient:id/textViewLastName").Text;

            return $"{firstName} {lastName}";

        }


        
    }
}
