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

        public void createPlayer(FootballPlayer player)
        {
            if (player == null)
            {
                throw new System.ArgumentNullException(nameof(player));
            }
            _context.FootballPlayers.Add(player);
            _context.SaveChanges();
        }

        public void deletePlayer(FootballPlayer player)
        {
            if (player == null)
            {
                throw new System.ArgumentNullException(nameof(player));
            }

            _context.FootballPlayers.Remove(player);
            _context.SaveChanges();
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

        public FootballPlayer getPlayerByLastname(string lastaname)
        {
            var player = (FootballPlayer)_context.FootballPlayers.Where(p => p.lastname == lastaname);

            return player;
        }

        public void updatePlayer(FootballPlayer player)
        {
            if (player == null)
            {
                throw new System.ArgumentNullException(nameof(player));
            }

            var playerModel = _context.FootballPlayers.FirstOrDefault(p => p.Id == player.Id);

            if (playerModel == null)
            {
                throw new System.NullReferenceException();
            }

            playerModel.lastname = player.lastname;
            playerModel.shirtNumber = player.shirtNumber;
            playerModel.speed = player.speed;
            playerModel.skill = player.skill;

            _context.SaveChanges();
        }
    }
}