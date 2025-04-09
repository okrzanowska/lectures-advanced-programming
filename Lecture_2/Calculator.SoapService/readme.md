1. Postman post body request: http://localhost:5255/soap
```xml
<soap:Envelope xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <Add>
      <a>7</a>
      <b>9</b>
    </Add>
  </soap:Body>
</soap:Envelope>
```

![image](https://github.com/user-attachments/assets/67430e46-5c5c-448d-bee5-661f4caff4b7)

![image](https://github.com/user-attachments/assets/006603c2-91c5-4234-8766-960b257103e4)

2. Alternative for Postman usage. Run script PostRequest.ps1 included in the repo. https://github.com/ldsupervisor/Lectures/blob/master/Lecture_2/Calculator.SoapService/PostRequest.ps1
   
![image](https://github.com/user-attachments/assets/ba9b9cbc-9cef-45d0-8e33-3ff0d3000723)

3. Alternative for Postman usage. Use http post request directly from Visual Studio. You could find it upon there:
https://github.com/ldsupervisor/Lectures/blob/master/Lecture_2/Calculator.SoapService/Calculator.SoapService.http

![image](https://github.com/user-attachments/assets/27fc47d9-af4f-4f8e-a041-7e6bf2fc8da2)


