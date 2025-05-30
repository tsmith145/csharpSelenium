
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

public class LoginPage
{



    IWebDriver _driver;

    //[FindsBy(How = How.Id, Using = "username")]
    IWebElement _usernameTextBox => _driver.FindElement(By.Id("username"));

    //[FindsBy(How = How.Id, Using = "password")]
    IWebElement _passwordTextBox => _driver.FindElement(By.Id("password"));

    IWebElement _loginButton => _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));



    public LoginPage(IWebDriver driver)
    {
        this._driver = driver;

    }



    public void enterUsername()
    {
        _usernameTextBox.SendKeys("practice");

    }

    public void enterPassword()
    {
        _passwordTextBox.SendKeys("SuperSecretPassword!");

    }

    public void clickButton()
    {
        _driver.Manage().Window.Maximize();



        WebDriverWait wait = new WebDriverWait(new SystemClock(), _driver, TimeSpan.FromSeconds(25), TimeSpan.FromSeconds(5));
        wait.Until(e=> e.FindElement(By.XPath("//button[normalize-space()='Login']")));
        _loginButton.Click();
    }
}