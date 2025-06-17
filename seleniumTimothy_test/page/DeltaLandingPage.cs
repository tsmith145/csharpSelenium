

using OpenQA.Selenium;

public class DeltaLandingPage
{

    IWebDriver _driver;

    ////div[@class='airport-lookup-tablist-container pl-0 pr-0 mt-2']
   

    ////span[normalize-space()='To']
    IWebElement _arrivalCityButton => _driver.FindElement(By.XPath("//span[normalize-space()='To']"));

    IWebElement _departureCityButton => _driver.FindElement(By.XPath("//span[normalize-space()='ATL']"));

    IWebElement _destinationAlertBox => _driver.FindElement(By.XPath("//div[@class='airport-lookup-tablist-container pl-0 pr-0 mt-2']"));

     ////input[@id='search_input']
    public DeltaLandingPage(IWebDriver driver)
    {
        this._driver = driver;


    }


    public void ChooseDestination()
    {
        _arrivalCityButton.Click();

        _driver.SwitchTo().Frame(_destinationAlertBox);
        
    }
}
     