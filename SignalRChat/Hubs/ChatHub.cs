using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            //Clients.All.hello();
        }

        public void Send(string name, string message)
        {
            if (message.Contains("foda"))
            {
                Clients.Caller.addNewMessageToPage(name, "Não é para falar palavrão seu puto");
                return;
            }
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }

        public void sendWelcome(string name)
        {
            Clients.Caller.addNewMessageToPage("Sistema", "Seja bem vindo ao melhor chat do mundo " + name);
        }
    }
}