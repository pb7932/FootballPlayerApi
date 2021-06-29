using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FootballPlayerApi.Data;
using FootballPlayerApi.Models;
using FootBallPlayerApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FootBallPlayerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayersController : ControllerBase
    {
        private readonly IFootballPlayerRepo _repository;
        private readonly IMapper _mapper;

        public FootballPlayersController(IFootballPlayerRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<FootballPlayer>> GetTModels()
        {
            var playersModel = _repository.getAllPlayers();
            var playersReadDto = _mapper.Map<IEnumerable<FootballPlayerReadDto>>(playersModel);

            return Ok(playersReadDto);
        }

        [HttpGet("{id}")]
        public ActionResult<FootballPlayer> GetTModelById(int id)
        {
            var playerModel = _repository.getPlayerById(id);

            if (playerModel == null)
            {
                return NotFound();
            }
            var playerReadDto = _mapper.Map<FootballPlayerReadDto>(playerModel);

            return Ok(playerReadDto);
        }
    }
}