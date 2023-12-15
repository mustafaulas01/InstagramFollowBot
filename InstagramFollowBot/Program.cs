using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Net;

public class Program
{
    private static async Task Main(string[] args)
    {
            List<string> followList = new List<string>();


             //I add people to follow to a list.

            followList.Add("https://www.instagram.com/medcezircamping/");
            followList.Add("https://www.instagram.com/isml.clk/");

            using (IWebDriver driver = new ChromeDriver())
            {
               driver.Navigate().GoToUrl("https://www.instagram.com/");
            
              Thread.Sleep(2000);

               string xpathUserName = "//*[@class='_aa4b _add6 _ac4d _ap35']";
               string xpathPass = "//*[@class='_aa4b _add6 _ac4d _ap35']";
            
            // Find input of username element
             IWebElement elementUserName = driver.FindElement(By.XPath(xpathUserName));

            // Enter instagram username
             elementUserName.SendKeys("The email you are registered with on Instagram");
            
            IWebElement elementPassword = driver.FindElement(By.XPath(xpathPass));
            elementPassword.SendKeys("your instagram password");



           //Submit Log In button
            IWebElement loginButton = driver.FindElement(By.CssSelector("._acan._acap._acas._aj1-._ap30"));
            IJavaScriptExecutor jsExecutorL = (IJavaScriptExecutor)driver;
            loginButton.Click();
            Console.WriteLine("Successfull Login !");

            Thread.Sleep(6000);

            try
            {
                // notSaveButtonParent
                IWebElement element = driver.FindElement(By.ClassName("_ac8f"));

                //  notSaveButton
                IWebElement firstChild = element.FindElement(By.XPath("./*"));

                firstChild.Click();
                Thread.Sleep(3000);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login Error: {ex.Message}");
            }
     
            // İf success Login  => getnotificationButton
            IWebElement elementNotification = driver.FindElement(By.CssSelector("._a9--._ap36._a9_1"));
            
            elementNotification.Click();
            Thread.Sleep(3000);

   
            // List I want to follow automatically
            foreach (var followinAdress in followList)
            {
                driver.Navigate().GoToUrl(followinAdress);

                //I want to sure to load page thats why ı wait
                Thread.Sleep(4000);
                try
                {
                    //Follow Button
                    IWebElement aButton = driver.FindElement(By.CssSelector("._acan._acap._acas._aj1-._ap30"));

                    if (aButton != null)
                    {
                        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;


                        aButton.Click();
                        Console.WriteLine("Clicked Follow Button");
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        Console.WriteLine("Not Choosen Follow Button");
                    }
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR ! :" + ex.Message);
                }

              
            }



            driver.Quit();
        
            }

    
          
     
    }
}