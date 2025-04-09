using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace Calculator.SoapService.Controllers
{
    [ApiController]
    [Route("soap")]
    public class SoapController : ControllerBase
    {
        [HttpPost]
        public IActionResult Invoke([FromBody] XmlElement soapEnvelope)
        {
            try
            {
                Console.WriteLine("SOAP envelope received:");
                Console.WriteLine(soapEnvelope.OuterXml);

                var doc = new XmlDocument();
                doc.LoadXml(soapEnvelope.OuterXml);

                var method = doc.GetElementsByTagName("Add")?.Item(0);
                if (method == null)
                    return BadRequest("No Add method found in SOAP envelope.");

                int a = int.Parse(method["a"]?.InnerText ?? "0");
                int b = int.Parse(method["b"]?.InnerText ?? "0");

                int result = a + b;

                var responseXml = $@"
<soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
    <soap:Body>
        <AddResponse>
            <Result>{result}</Result>
        </AddResponse>
    </soap:Body>
</soap:Envelope>";

                return Content(responseXml, "text/xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SOAP ERROR: " + ex.Message);
                return new ContentResult
                {
                    StatusCode = 500,
                    ContentType = "text/plain",
                    Content = $"SOAP error: {ex.Message}"
                };
            }
        }
    }
}
