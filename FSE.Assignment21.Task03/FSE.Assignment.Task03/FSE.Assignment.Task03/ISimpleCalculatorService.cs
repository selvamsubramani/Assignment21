using System.ServiceModel;

namespace FSE.Assignment.Task03
{
    [ServiceContract]
    public interface ISimpleCalculatorService
    {
        [OperationContract]
        int Add(int a, int b);
        [OperationContract]
        int Subtract(int a, int b);
    }
}
