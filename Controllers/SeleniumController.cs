using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace iis_hosted.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeleniumController : ControllerBase
    {
        private readonly ILogger<SeleniumController> _logger;
        private IWebDriver _driver;

        public SeleniumController(ILogger<SeleniumController> logger, IWebDriver driver)
        {
            _logger = logger;
            _driver = driver;
        }

        [HttpPost(Name = "Start")]
        public void Start()
        {
            _driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(20000);
            _driver.Quit();
        }
    }
}
