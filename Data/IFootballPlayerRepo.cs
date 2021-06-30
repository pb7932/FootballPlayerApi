using System.Collections.Generic;
using FootballPlayerApi.Models;

namespace FootballPlayerApi.Data
{
    public interface IFootballPlayerRepo
    {
        IEnumerable<FootballPlayer> getAllPlayers();
        FootballPlayer getPlayerById(int id);
        FootballPlayer getPlayerByLastname(string lastaname);
        void createPlayer(FootballPlayer player);
        void updatePlayer(FootballPlayer player);
        void deletePlayer(FootballPlayer player);
    }
}