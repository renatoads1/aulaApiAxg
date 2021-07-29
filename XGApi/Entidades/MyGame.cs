using System;
using System.Collections.Generic;
using System.Text;

namespace XGApi.Entidades
{
    public class MyGame
    {
        public Guid Id { get; set; }
        public GamePlatform GamePlatform { get; set; }
        public bool Seel { get; set; }
        public bool Trade { get; set; }
        public bool Buy { get; set; }
    }
}
