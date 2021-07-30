using System;
using System.Collections.Generic;
using System.Text;
using XGApi.Arguments.Player;
using XGApi.Entidades;

namespace XGApi.Interfaces.Repositorios
{
    public interface IRepositoryPlayer
    {
        AutenticaPlayerResponse AutenticaPlayer(AutenticaPlayerRequest request);

        Guid AdicionarPlayer(Player player);
    }
}
