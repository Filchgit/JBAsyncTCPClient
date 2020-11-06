using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace JBAsyncSocketClientConsoleApp
{
    public class JBAsynchTCPClient
    {
        IPAddress myServerIPAddress;
        int myServerPort;
        TcpClient myTcpClient;
        //adding the member variables to this class

        public JBAsynchTCPClient()
        {  //declaring class constructor and setting default values
            myTcpClient = null;
            myServerPort = -1;
            myServerIPAddress = null;
        }
        public IPAddress ServerIPAddress
        {
            get
            {
                return myServerIPAddress;
            }
        }
        public int ServerPort
        {
            get
            {
                return myServerPort;
            }
        }
        public bool SetServerIPAdress(string _IPAddressServer)
        {
            IPAddress ipaddr = null;
            if(!IPAddress.TryParse(_IPAddressServer,out ipaddr))
            {
                Console.WriteLine("Invalid server IP supplied.");
                return false;
            }

            myServerIPAddress = ipaddr;
            return true;

        }
        public bool SetPortNumber(string _ServerPort)
        {
            int portNumber = 0;

            if(!int.TryParse(_ServerPort.Trim(), out portNumber))
            {
                Console.WriteLine("Invalid port number supplied, return.");
                return false;
            }
            if(portNumber <= 0 ||portNumber > 65535 )
            {
                Console.WriteLine("Port Number must be between 0 and 65535.");
                return false;
            }
            
            return true;
        }
    }
}
