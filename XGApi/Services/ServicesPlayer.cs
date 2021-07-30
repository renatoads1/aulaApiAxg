using prmToolkit.NotificationPattern;
using System;
using XGApi.Arguments.Player;
using XGApi.Entidades;
using XGApi.EntidadeSolida;
using XGApi.Interfaces.Repositorios;
using XGApi.Interfaces.Servicos;
using XGApi.Resources;

/*
beneficios 
implementar clases com interfaces estaticas 
"não mudam por reflexo da classe"
menor acoplamento
*/

namespace XGApi.Services
{
    //hoje nós descobrimos que tem como extender duas clases ou mais colocando virgula 
    public class ServicesPlayer : Notifiable, IServicesPlayer 
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
            var email = new Email("renatoads1@gmail.com");
            var nome = new Nomes("Renato", "Azevedo");
     
            Player player = new Player(nome,email,"r3n4t0321");

            Guid id = _repositoryplayer.AdicionarPlayer(player);
            return new AdicionarPlayerResponse() { Id = id, Message = "Operação Realizada"};
        }

        public AutenticaPlayerResponse AutenticaPlayer(AutenticaPlayerRequest request)
        {
            if (request == null)
            {

                AddNotification("Autenticar", "Autenticar Jogdor Request é Obrigtório");
            }

            var nome = new Nomes(request.Nome.FirstName, request.Nome.LestName);
            var email = new Email(request.Email.Address);
            var password = request.Password;
            var player = new Player(nome,email, password);
            //mandando msg de erro atraves de resource 'arquivo de configuração'
            AddNotification(player.Email.Address.ToString(),string.Format(Message.X0_E_OBRIGATORIO, "player.Email.Address.ToString() erro->"));

            if (player.IsInvalid())
            {
                return null;
            }
            return  _repositoryplayer.AutenticaPlayer(request);
             
        }
    }
}
