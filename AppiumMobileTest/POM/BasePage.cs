using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumMobileTests.POM
{
    public abstract class BasePage
    {
        protected AndroidDriver<AndroidElement> driver; 

        protected BasePage(AndroidDriver<AndroidElement> driver) 
        
        {
            this.driver = driver;
        }   

    }
}
