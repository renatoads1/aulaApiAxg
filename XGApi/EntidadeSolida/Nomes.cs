using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace XGApi.EntidadeSolida
{
    public class Nomes : Notifiable
    {
        public string FirstName { get; private set; }
        public string LestName { get; private set; }

        public Nomes(string firstName, string lestName)
        {
            FirstName = firstName;
            LestName = lestName;

            new AddNotifications<Nomes>(this).
                IfNullOrEmptyOrInvalidLength(_ => _.FirstName, 4, 22, "inválido").
                IfNullOrEmptyOrInvalidLength(_ => _.LestName, 4, 22, "inválido");
        }
    }
}
