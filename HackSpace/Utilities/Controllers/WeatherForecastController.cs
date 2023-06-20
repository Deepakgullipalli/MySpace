using Aspose.Email;
using Aspose.Email.Mapi;
using Microsoft.AspNetCore.Mvc;

namespace Utilities.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("Download")]
        public IActionResult DownloadEmail()
        {
            MailMessage mailMessage = new MailMessage("from@domain.com", "to@domain.com", "Subject", "Body")
            {
                HtmlBody = "<h1>This is a heading</h1><p>This is a paragraph.</p><p>This is another paragraph.</p>"
            };

            MapiMessage mapiMessage = MapiMessage.FromMailMessage(mailMessage);
            mapiMessage.Save("email.msg");

            byte[] fileBytes = System.IO.File.ReadAllBytes("email.msg");

            return File(fileBytes, "application/vnd.ms-outlook", "email.msg");
        }
    }
}