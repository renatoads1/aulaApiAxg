using XGApi.EntidadeSolida;
using XGApi.Interfaces.Argumentos;

namespace XGApi.Arguments.Player
{
    public class AdicionarPlayerRequest : IRequest
    {
        public Nomes Nome { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
    }
}
