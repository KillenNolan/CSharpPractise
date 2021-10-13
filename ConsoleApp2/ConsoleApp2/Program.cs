using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.writeToCenDB_wms_WS_PortTypeClient client 
                = new ServiceReference1.writeToCenDB_wms_WS_PortTypeClient();
            client.writeToCenDB_wms()
        }
    }
}
