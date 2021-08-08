using Application.MovieOperations.Commands;
using Application.MovieOperations.Queries;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Entities;
using System.Linq;

namespace Application.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieVM>()
                .ForMember(dest => dest.PublishDate, opt => opt.MapFrom(src => src.PublishDate.Date.ToString("dd/MM/yyy")))
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.FullName))
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.Actors.Select(x => x.FullName).ToList()));

            CreateMap<Movie, MovieDetailVM>()
                .ForMember(dest => dest.PublishDate, opt => opt.MapFrom(src => src.PublishDate.Date.ToString("dd/MM/yyy")))
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.FullName))
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.Actors.Select(x => x.FullName).ToList()));
            
            CreateMap<int, Actor>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src));

            CreateMap<CreateMovieM, Movie>()
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.ActorsIds));

        }
    }
}
