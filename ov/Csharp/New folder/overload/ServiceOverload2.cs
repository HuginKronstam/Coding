using System;
using System.Collections.Generic;
using System.Text;

namespace overload
{
    class ServiceOverload2
    {
        public void StopService(bool forceStop ,string serviceName)
        {
            Console.WriteLine("Force Stop: {0} Service Name: {1} Service Id: {2} ", forceStop, serviceName, 1);
            Console.ReadKey(true);
        }
        public void StopService(string serviceName)
        {
            Console.WriteLine("Force Stop: {0} Service Name: {1} Service Id: {2} ", true, serviceName, 2);
            Console.ReadKey(true);
        }
        public void StopService(bool forceStop, string serviceName, int serviceId)
        {
            Console.WriteLine("Force Stop: {0} Service Name: {1} Service Id: {2} ", forceStop, serviceName, serviceId);
            Console.ReadKey(true);
        }

        
    }
}
