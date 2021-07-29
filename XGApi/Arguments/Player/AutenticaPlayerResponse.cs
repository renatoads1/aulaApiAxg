using System;
using XGApi.EntidadeSolida;
using XGApi.Interfaces.Argumentos;

namespace XGApi.Arguments.Player
{
    public class AutenticaPlayerResponse: IResponse
    {
        public Guid Id { get; set; }
        public Email Email { get; set; }
    }
}
