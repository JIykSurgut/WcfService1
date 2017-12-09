using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfClient
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        double GetPrice(string ticker);
    }

    class Client
    {
        static void Main(string[] args)
        {
            ChannelFactory<IStockService> myChannelFactory =
                new ChannelFactory<IStockService>(
                    new BasicHttpBinding(), 
                    new EndpointAddress("http://localhost:8080/EssentialWCF"));

            IStockService wcfClient = myChannelFactory.CreateChannel();

            Console.ReadKey();
            double p = wcfClient.GetPrice("msft");
            Console.WriteLine("Price:{0}",p);
            Console.ReadKey();
        }
    }
}
