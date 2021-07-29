using System;
using System.Collections.Generic;
using System.Text;

namespace XGApi.Entidades
{
    public class GamePlatform
    {
        public Guid Id { get; set; }
        public Game Game { get; set; }
        public Platform Platform { get; set; }
        public DateTime DataLancamento { get; set; }


    }
}
