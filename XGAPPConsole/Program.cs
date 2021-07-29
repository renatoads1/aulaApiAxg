using System;
using System.Collections.Generic;
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
            servico.AutenticaPlayer(request);

        }
    }
}
