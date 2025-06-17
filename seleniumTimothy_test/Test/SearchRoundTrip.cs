
 using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

public class SearchRoundTrip
{
    [Test, Order(1)]
    [Category("Selenium")]
    public void OpenBrowser()
    {

        var expectedAlertText = "Change Your Password";
        IWebDriver driver = new ChromeDriver(@"C:\Users\Mjrlo\Downloads\chromedriver-win64 (2)\csharpdriver");
        driver.Navigate().GoToUrl("https://practice.expandtesting.com/login/");


        DeltaLandingPage deltaLanding = new DeltaLandingPage(driver);
        loginTest.enterPassword();
        loginTest.enterUsername();


        loginTest.clickButton();
        var alert = driver.SwitchTo().Alert();
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        Assert.Equals(expectedAlertText, alert.Text);
    }
}  