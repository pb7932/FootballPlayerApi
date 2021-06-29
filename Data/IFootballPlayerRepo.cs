using System.Collections.Generic;
using FootballPlayerApi.Models;

namespace FootballPlayerApi.Data
{
    public interface IFootballPlayerRepo
    {
        IEnumerable<FootballPlayer> getAllPlayer();
        FootballPlayer getPlayerById(int id);
    }
}