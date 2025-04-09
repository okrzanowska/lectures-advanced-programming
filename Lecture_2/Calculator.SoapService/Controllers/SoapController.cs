using Microsoft.AspNetCore.Mvc;
using System.Xml;

namespace Calculator.SoapService.Controllers
{
    [ApiController]
    [Route("soap")]
    public class SoapController : ControllerBase
    {
        [HttpPost]
        [Consumes("text/xml")]
        public async Task<IActionResult> Invoke()
        {
            try
            {
                using var reader = new StreamReader(Request.Body);
                var rawXml = await reader.ReadToEndAsync();

                var doc = new XmlDocument();
                doc.LoadXml(rawXml);

                var method = doc.GetElementsByTagName("Add")?.Item(0);
                if (method == null)
                    return BadRequest("No Add method found in SOAP envelope.");

                int a = int.Parse(method["a"]?.InnerText ?? "0");
                int b = int.Parse(method["b"]?.InnerText ?? "0");

                int result = a + b;

                var responseXml = $@"<soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
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
                return StatusCode(500, $"SOAP error: {ex.Message}");
            }
        }
    }
}
