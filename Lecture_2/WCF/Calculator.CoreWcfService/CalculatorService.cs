using CoreWCF;
using System.Runtime.Serialization;

namespace Calculator.CoreWcfService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Subtract(int a, int b);

        [OperationContract]
        int Multiply(int a, int b);

        [OperationContract]
        int Divide(int a, int b);
    }

    [DataContract]
    public class ServiceFault
    {
        [DataMember]
        required public string Message { get; set; }
    }

    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new FaultException<ServiceFault>(
                        new ServiceFault { Message = "You should not divide by zero. Replace the divider." },
                        new FaultReason("Divide by zero"));
                }

                return a / b;
            }

            catch (FaultException<ServiceFault>)
            {
                throw;
            }

            catch (Exception ex)
            {
                throw new FaultException<ServiceFault>(
                    new ServiceFault { Message = $"Unexpected error: {ex.Message}" },
                    new FaultReason("Unexpected error"));
            }

            finally
            {
                Console.WriteLine($"Divide({a}, {b})");
            }
        }
    }
}

