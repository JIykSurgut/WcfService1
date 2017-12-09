using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetData(int value);
    }
}
