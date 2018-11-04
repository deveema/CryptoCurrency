using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoCurrency.Hubs
{
    public class CurrencyHub : Hub
    {
        public async Task Get(string price)
        {
            await this.Clients.All.SendAsync("Get", price);
        }
    }
}
