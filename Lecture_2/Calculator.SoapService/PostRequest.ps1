$body = @"
<soap:Envelope xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <Add xmlns="http://localhost:5255/soap">
      <a>7</a>
      <b>9</b>
    </Add>
  </soap:Body>
</soap:Envelope>
"@

Invoke-WebRequest -Uri "http://localhost:5255/soap" `
  -Method Post `
  -ContentType "text/xml; charset=utf-8" `
  -Body $body
