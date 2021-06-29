using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballPlayerApi.Data;
using FootballPlayerApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootBallPlayerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayersController : ControllerBase
    {
        private readonly IFootballPlayerRepo _repository;

        public FootballPlayersController(IFootballPlayerRepo repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<FootballPlayer>> GetTModels()
        {
            var players = _repository.getAllPlayers();
            return Ok(players);
        }

        [HttpGet("{id}")]
        public ActionResult<FootballPlayer> GetTModelById(int id)
        {
            var player = _repository.getPlayerById(id);

            return Ok(player);
        }
    }
}