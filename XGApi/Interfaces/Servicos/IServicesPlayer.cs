using XGApi.Arguments.Player;

namespace XGApi.Interfaces.Servicos
{
    public interface IServicesPlayer
    {
        AutenticaPlayerResponse AutenticaPlayer(AutenticaPlayerRequest request);

        AdicionarPlayerResponse AdicionarPlayer(AdicionarPlayerRequest request);

    }
}
