using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace AmazonPurchaseTest

class AmazonAgain
{

    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBoxSearch;
    static IWebElement textBox;
    static IWebElement textBoxPW;
    


    static void Main()
    {
        string url = "https://www.amazon.com/";

        driver.Navigate().GoToUrl(url);

        driver.Manage().Window.Maximize();

        //click the Search Bar and input text
        textBoxSearch = driver.FindElement(By.Name("field-keywords"));
        textBoxSearch.SendKeys("pokemon sword");



        //click the Search icon button
        driver.FindElement(By.CssSelector("#nav-search > form > div.nav-right > div > input")).Click();
        //driver.FindElement(By.XPath("//*[@id=\"nav - search\"]/form/div[2]/div/input")).Click();
        
        Thread.Sleep(3000);

        //click the Pokemon Sword title
        driver.FindElement(By.CssSelector("#search > div.s-desktop-width-max.s-opposite-dir > div > div.sg-col-20-of-24.s-matching-dir.sg-col-28-of-32.sg-col-16-of-20.sg-col.sg-col-32-of-36.sg-col-8-of-12.sg-col-12-of-16.sg-col-24-of-28 > div > span:nth-child(4) > div.s-main-slot.s-result-list.s-search-results.sg-row > div.sg-col-20-of-24.s-result-item.s-asin.sg-col-0-of-12.sg-col-28-of-32.sg-col-16-of-20.AdHolder.sg-col.sg-col-32-of-36.sg-col-12-of-16.sg-col-24-of-28 > div > span > div > div > div > div > div:nth-child(2) > div.sg-col-4-of-12.sg-col-8-of-16.sg-col-16-of-24.sg-col-12-of-20.sg-col-24-of-32.sg-col.sg-col-28-of-36.sg-col-20-of-28 > div > div:nth-child(1) > div > div > div:nth-child(1) > h2 > a > span")).Click();
        Thread.Sleep(3000);

        //click the Buy Now button
        driver.FindElement(By.Name("submit.buy-now")).Click();
        Thread.Sleep(3000);

        //ID the Text Box and input text
        textBox = driver.FindElement(By.Name("email"));
        textBox.SendKeys("email@gmail.com");

        //Click the Continue button
        driver.FindElement(By.Id("continue")).Click();
        Thread.Sleep(5000);

        //ID the Password Text Box and input text
        textBoxPW = driver.FindElement(By.Name("password"));
        textBoxPW.SendKeys("abcdefg");

        //Click the Sign-In button
        driver.FindElement(By.Id("signInSubmit")).Click();

        Thread.Sleep(5000);

        driver.Quit();
    }
}

