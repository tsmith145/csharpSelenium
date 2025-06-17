
 using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

public class SearchRoundTrip
{
    [Test, Order(0)]
    [Category("Selenium")]
    public void OpenBrowser()
    {

        

        IWebDriver driver = new ChromeDriver(@"C:\Users\Mjrlo\Downloads\chromedriver-win64 (2)\csharpdriver");
        driver.Navigate().GoToUrl("https://www.delta.com/");


        DeltaLandingPage deltaLanding = new DeltaLandingPage(driver);
        


        
     //   var alert = driver.SwitchTo().Alert();
      //  var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

///Assert.Equals(expectedAlertText, alert.Text);
    }
}  