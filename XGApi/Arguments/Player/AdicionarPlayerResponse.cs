using System;
using System.Collections.Generic;
using System.Text;
using XGApi.Interfaces.Argumentos;

namespace XGApi.Arguments.Player
{
    public class AdicionarPlayerResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
