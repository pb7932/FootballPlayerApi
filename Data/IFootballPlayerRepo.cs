using System.Collections.Generic;
using FootballPlayerApi.Models;

namespace FootballPlayerApi.Data
{
    public interface IFootballPlayerRepo
    {
        IEnumerable<FootballPlayer> getAllPlayers();
        FootballPlayer getPlayerById(int id);
    }
}