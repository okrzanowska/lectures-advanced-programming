<h1>Lecture_1</h1>

1. **Run CalculatorApi**. If the server is properly running you should obtain the message:<br>

![image](https://github.com/user-attachments/assets/480ddade-a4cf-43de-8ed1-c329b50a4f7e)


2. Run separate second instance of Visual Studio and run **RestClient**. Alternatively, you can test the server using one of the following three options below:<br>
   a) Open web browser and type the request http://localhost:5129/api/calculator/add?a=5&b=10.
   b) Open 'Calculator.Api.http' and send request directly from VS IDE ![image](https://github.com/user-attachments/assets/a7d126d9-c57f-4718-9f96-97aa2559044e)
   c) Download **Postmam** application and test 'GET'request.  ![image](https://github.com/user-attachments/assets/5308ee53-8c58-4673-b43e-7e81849dd36c)
   


3. You could choose any numbers you want to add in the URL.
4. Try to add your own controller in the solution.
5. You could modify 'Properties -> LaunchSettings.json' to use different ports on your local host machine if you wish.
