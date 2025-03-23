<h1>Lecture_1</h1>
1. Run CalculatorApi. If the server is properly running you should obtain the message:<br>
   ![image](https://github.com/user-attachments/assets/aa119da0-1215-4b26-befd-1580467fa4a1)


3. Run separate second instance of Visual Studio and run RestClient. There are eventually other 3 options to check the behaviour of server: a), b) or c)<br>
   a) Open web browser and type the request http://localhost:5129/api/calculator/add?a=5&b=10.
   b) Open Calculator.Api.http and send request directly from VS IDE ![image](https://github.com/user-attachments/assets/a7d126d9-c57f-4718-9f96-97aa2559044e)
   c) Download Postmam application and test <em>GET</em> request.  ![image](https://github.com/user-attachments/assets/5308ee53-8c58-4673-b43e-7e81849dd36c)

4. You could choose whatever numbers you want to add in the url.
5. Try to add your own controller in the solution.
6. You could modify Properties -> LaunchSettings.json to use different ports on your local machine.
