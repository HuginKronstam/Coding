using System;
using System.Collections.Generic;
using System.Text;

namespace overload
{
    class ServiceOverload
    {
        public void StopService(bool forceStop, string serviceName = null, int serviceId = 1)
        {
            Console.WriteLine( "Force Stop: {0} Service Name: {1} Service Id: {2} ", forceStop, serviceName, serviceId);
            Console.ReadKey(true);
        }
    

        public bool IsOnline(string serviceName, out string statusMessage)
        {
        
            bool isOnline = true;

            if (isOnline)
            {
                statusMessage = "service is currently running";
                Console.WriteLine(statusMessage);
            }
            else
            {
                statusMessage = "Service is currently offline";
                Console.WriteLine(statusMessage);
            }
            return isOnline;
        }
    }
}
