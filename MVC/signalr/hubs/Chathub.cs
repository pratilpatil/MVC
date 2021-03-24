using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace MVC.signalr.hubs
{
    public class MyHubC1 : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addNewmessageToPage(name, message);
        
        }
    }
}