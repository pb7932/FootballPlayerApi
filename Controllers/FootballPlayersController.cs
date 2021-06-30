using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FootballPlayerApi.Data;
using FootballPlayerApi.Models;
using FootBallPlayerApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootBallPlayerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<FootballPlayer>> GetAllPlayers()
        {
            var playersModel = _repository.getAllPlayers();
            var playersReadDto = _mapper.Map<IEnumerable<FootballPlayerReadDto>>(playersModel);

            return Ok(playersReadDto);
        }

        [HttpGet("{id}", Name = "GetPlayerById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FootballPlayer> GetPlayerById(int id)
        {
            var playerModel = _repository.getPlayerById(id);

            if (playerModel == null)
            {
                return NotFound();
            }
            var playerReadDto = _mapper.Map<FootballPlayerReadDto>(playerModel);

            return Ok(playerReadDto);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<FootballPlayerReadDto> CreatePlayer(FootballPlayerCreateDto playerCreateDto)
        {
            var playerModel = _mapper.Map<FootballPlayer>(playerCreateDto);
            _repository.createPlayer(playerModel);

            var playerReadDto = _mapper.Map<FootballPlayerReadDto>(playerModel);

            return CreatedAtRoute(nameof(GetPlayerById), new { id = playerReadDto.Id }, playerReadDto);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeletePlayerById(int id)
        {
            var playerToDelete = _repository.getPlayerById(id);

            if (playerToDelete == null)
            {
                return NotFound();
            }

            _repository.deletePlayer(playerToDelete);

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdatePlayer(int id, FootballPlayerUpdateDto playerUpdateDto)
        {
            var playerToUpdate = _repository.getPlayerById(id);

            if (playerToUpdate == null)
            {
                return NotFound();
            }

            _mapper.Map(playerUpdateDto, playerToUpdate);

            _repository.updatePlayer(playerToUpdate);

            return NoContent();
        }
    }
}