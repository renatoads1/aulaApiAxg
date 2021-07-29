using System;
using System.Collections.Generic;
using System.Text;
using XGApi.EntidadeSolida;
using XGApi.Enumeradores;

namespace XGApi.Entidades
{
    public class Player
    {
        public Guid Id { get; set; }
        public Nomes Nome { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
        public EnumStatusPlayer  Status { get; set; }
    }
}
