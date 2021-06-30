using FootballPlayerApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FootBallPlayerApi.Controllers
{
    [ApiController]
    [Route("api/validation")]
    [Authorize]
    public class FootballPlayersValidationController : Controller, IFootballPlayersValidation
    {
        private readonly IFootballPlayerRepo _repository;

        public FootballPlayersValidationController(IFootballPlayerRepo repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [HttpGet]
        [AllowAnonymous]
        public JsonResult VeirfyLastname(string lastname)
        {
            var player = _repository.getPlayerByLastname(lastname);

            if (player == null)
            {
                return Json(true);
            }

            return Json($"Lastname {lastname} is already in use.");
        }
    }
}