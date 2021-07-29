using System;
using XGApi.Arguments.Player;
using XGApi.Interfaces.Repositorios;
using XGApi.Interfaces.Servicos;

/*
beneficios 
implementar clases com interfaces estaticas 
"não mudam por reflexo da classe"
menor acoplamento
*/

namespace XGApi.Services
{
    public class ServicesPlayer : IServicesPlayer
    {
        private readonly IRepositoryPlayer _repositoryplayer;

        public ServicesPlayer()
        {
        }

        public ServicesPlayer(IRepositoryPlayer repositoryplayer)
        {
            _repositoryplayer = repositoryplayer;
        }

        public AdicionarPlayerResponse AdicionarPlayer(AdicionarPlayerRequest request)
        {
            Guid id = _repositoryplayer.AdicionarPlayer(request);
            return new AdicionarPlayerResponse() { Id = id, Message = "Operação Realizada" };
        }

        public AutenticaPlayerResponse AutenticaPlayer(AutenticaPlayerRequest request)
        {
            if (request == null)
            {
                throw new Exception("É Obrigatório Autenticar o jogador");
            }
            if (String.IsNullOrEmpty(request.Email.Address)) {
                throw new Exception("Informe o email");
            }
            if (String.IsNullOrEmpty(request.Password))
            {
                throw new Exception("Informe a senha");
            }
            if (request.Password.Length <= 7)
            {
                throw new Exception("Informe Uma senha Mais Forte");
            }

            return  _repositoryplayer.AutenticaPlayer(request);
             
        }
    }
}
