using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using XGApi.Resources;

namespace XGApi.EntidadeSolida
{
    public class Email : Notifiable
    {
        public string Address { get;  set; }

        public Email(string address)
        {
            Address = address;

            new AddNotifications<Email>(this)
                .IfNotEmail(address, Message.X0_E_INVALIDO.ToFormat("E-mail"));
        }
    }
}
