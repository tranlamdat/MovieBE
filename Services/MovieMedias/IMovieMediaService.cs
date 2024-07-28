using Microsoft.AspNetCore.Mvc;
using Sever.Dto.MovieActor;
using Sever.Dto.MovieMedia;

namespace Sever.Services.MovieMedias
{
    public interface IMovieMediaService
    {
        Task<MovieMediaDto> AddMovieMedia(CreateMovieMediaDto createMovieMediaDto);

        Task<MovieMediaDto> UpdateMovieMedia(int id, CreateMovieMediaDto createMovieMediaDto);

        Task<string> DeleteMovieMedia(int id);
    }
}
