using System.Collections.Generic;
using FootballPlayerApi.Models;

namespace FootballPlayerApi.Data
{
    public class MockFootballPlayerRepo : IFootballPlayerRepo
    {
        public void createPlayer(FootballPlayer player)
        {
            throw new System.NotImplementedException();
        }
        public void deletePlayer(FootballPlayer player)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<FootballPlayer> getAllPlayers()
        {
            var players = new List<FootballPlayer>(){
                new FootballPlayer {
                     Id = 0,
                    lastname = "messi",
                    shirtNumber = 10,
                    speed = 98,
                    skill = 96
                },
                new FootballPlayer {
                     Id = 1,
                    lastname = "perisic",
                    shirtNumber = 4,
                    speed = 91,
                    skill = 85
                },
                new FootballPlayer {
                     Id = 2,
                    lastname = "ronaldo",
                    shirtNumber = 10,
                    speed = 98,
                    skill = 99
                }
            };

            return players;
        }

        public FootballPlayer getPlayerById(int id)
        {
            var player = new FootballPlayer()
            {
                Id = 0,
                lastname = "messi",
                shirtNumber = 10,
                speed = 98,
                skill = 96
            };

            return player;
        }

        public FootballPlayer getPlayerByLastname(string lastaname)
        {
            throw new System.NotImplementedException();
        }

        public void updatePlayer(FootballPlayer player)
        {
            throw new System.NotImplementedException();
        }
    }
}