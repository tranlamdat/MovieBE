using Microsoft.AspNetCore.Mvc;
using Sever.Dto.MovieMedia;

namespace Sever.Services.MovieMedias
{
    public interface IMovieMediaService
    {
        Task<MovieMediaDto> AddMovieMedia(CreateMovieMediaDto createMovieMediaDto);

        Task<string> DeleteMovieMedia(int id);
    }
}
