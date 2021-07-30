using prmToolkit.NotificationPattern;
using System;
using XGApi.EntidadeSolida;
using XGApi.Enumeradores;
using XGApi.Extension;

namespace XGApi.Entidades
{
    public class Player : Notifiable
    {
        public Guid Id { get; private set; }
        public Nomes Nome { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }
        public EnumStatusPlayer Status { get; private  set; }

        public Player(Nomes nome, Email email,string password)
        {
            Nome = nome;
            Email = email;
            Password = password;

            new AddNotifications<Player>(this).IfNotEmail(_ => _.Email.Address, "Este email não é valido!!!").IfNullOrEmptyOrInvalidLength(_ => _.Password, 8, 24, "A senha deve ter entre 8 e 24 caracteres");

            password = password.ConvertToMD5();
                        
        }
    }
}
