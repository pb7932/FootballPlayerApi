using System.Collections.Generic;
using System.Linq;
using FootballPlayerApi.Data;
using FootballPlayerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FootBallPlayerApi.Data
{
    public class FootballPlayerRepo : IFootballPlayerRepo
    {
        private readonly FootballPlayerContext _context;

        public FootballPlayerRepo(FootballPlayerContext context)
        {
            _context = context;
        }
        public IEnumerable<FootballPlayer> getAllPlayers()
        {
            var players = _context.FootballPlayers.ToList();

            return players;
        }

        public FootballPlayer getPlayerById(int id)
        {
            var player = _context.FootballPlayers.FirstOrDefault(p => p.Id == id);

            return player;
        }
    }
}