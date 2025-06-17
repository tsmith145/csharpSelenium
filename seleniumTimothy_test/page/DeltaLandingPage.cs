

using OpenQA.Selenium;

public class DeltaLandingPage
{

    IWebDriver _driver;

    //[FindsBy(How = How.Id, Using = "username")]
    IWebElement _usernameTextBox => _driver.FindElement(By.Id("username"));

    ////span[normalize-space()='To']
    IWebElement _arrivalCityButton => _driver.FindElement(By.XPath("//span[normalize-space()='To']"));

    IWebElement _departureCityButton => _driver.FindElement(By.XPath("//span[normalize-space()='ATL']"));
    
}
     