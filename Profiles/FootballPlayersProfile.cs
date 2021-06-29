using AutoMapper;
using FootballPlayerApi.Models;
using FootBallPlayerApi.Dtos;

namespace FootBallPlayerApi.Profiles
{
    public class FootballPlayersProfile : Profile
    {
        public FootballPlayersProfile()
        {
            CreateMap<FootballPlayer, FootballPlayerReadDto>();
            CreateMap<FootballPlayerCreateDto, FootballPlayer>();
            CreateMap<FootballPlayerUpdateDto, FootballPlayer>();
        }
    }
}