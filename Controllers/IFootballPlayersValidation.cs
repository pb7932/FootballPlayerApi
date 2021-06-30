using Microsoft.AspNetCore.Mvc;

namespace FootBallPlayerApi.Controllers
{
    public interface IFootballPlayersValidation
    {
        JsonResult VeirfyLastname(string lastname);
    }
}