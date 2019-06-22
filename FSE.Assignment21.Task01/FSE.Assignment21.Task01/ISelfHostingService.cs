using System.ServiceModel;

namespace FSE.Assignment21.Task01
{
    [ServiceContract]
    public interface ISelfHostingService
    {
        [OperationContract]
        string SayHello(string name);
        [OperationContract]
        string TodayProgram(string name);
    }
}
