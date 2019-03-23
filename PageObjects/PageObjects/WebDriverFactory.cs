using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
namespace PageObjects
{
    public static class WebDriverFactory
    {
        private  const int Firefox = 1;
        private const int Chrome = 2;

        public static IWebDriver CreateWebDriver(int browser, string pathDriver, bool headless)
        {
            IWebDriver webDriver = null;
          
            switch (browser)
            {
                case Firefox:
                    FirefoxOptions optionsFF = new FirefoxOptions();
                    if (headless)
                        optionsFF.AddArgument("--headless");

                    webDriver = new FirefoxDriver(pathDriver, optionsFF);

                    break;
                case Chrome:
                    ChromeOptions optionsChr = new ChromeOptions();
                    if (headless)
                        optionsChr.AddArgument("--headless");

                    webDriver = new ChromeDriver(pathDriver, optionsChr);

                    break;
            }

            return webDriver;
        }
    }

}
