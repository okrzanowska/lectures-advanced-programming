<h1>Lecture_2 SOAP using WCF</h1>

Use WCF + Blazor profile to run all the three projects.

![image](https://github.com/user-attachments/assets/16228f99-c4dd-4f03-8d57-9582a9371eae)

The output should be as follows. You could use Blazor sample wep page to test the behaviour of simple four calculations.
WCF service could also be pinged by the WCF client. The numbers you want to operate with should be predefined in code in Program.cs in WCFClient project. Output from the WCF client is shown in Fig.1

![image](https://github.com/user-attachments/assets/ad96244c-1ad2-4250-9183-2a4af14ab80a)
Fig. 1 Console app client output

![image](https://github.com/user-attachments/assets/94a752ca-a709-4053-81cb-293d97ebbcf7)
Fig. 2 WSDL output

![image](https://github.com/user-attachments/assets/6b76128b-6239-47fc-85dc-a68bb8c29d5b)
Fig. 3 Service application output

![image](https://github.com/user-attachments/assets/46d27737-3562-4349-a7cf-23a3c96a2e1c)
Fig. 4 Blazor Web Page to present the results

![image](https://github.com/user-attachments/assets/f592a09b-b7e5-403f-b2fd-a14f949febdb)
Fig. 5 Blazor Web Page output console

Additionally url for WSDL checking:
http://localhost:5189/soap/calculator/wsdl

Service description:
http://localhost:5189/soap/calculator/wsdl?singleWsdl


