using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XGApi.Arguments.Player;
using XGApi.Services;

namespace XGAPPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var servico = new ServicesPlayer();

            AutenticaPlayerRequest request = new AutenticaPlayerRequest();
            request.Email.Address = "renatoads1@gmail.com";
            request.Password = "r3n4t0321";
            var response = servico.AutenticaPlayer(request);
            servico.Notifications.ToList().ForEach(_=> {
                Console.WriteLine(_.Message);
            });

        }
    }
}
