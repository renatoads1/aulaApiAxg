using System;
using System.Collections.Generic;
using System.Text;

namespace XGApi.Entidades
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Productor { get; set; }
        public string Distribuidora { get; set; }
        public string Genero { get; set; }
        public string Site { get; set; }
    }
}
