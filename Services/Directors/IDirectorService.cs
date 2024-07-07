using Sever.Dto.Actor;
using Sever.Dto.Director;

namespace Sever.Services.Directors
{
    public interface IDirectorService
    {
        Task<DirectorDto> AddDirector(CreateDirectorDto createDirectorDto);
        Task<DirectorDto> UpdateDirector(int id, UpdateDirectorDto updateDirectorDto);
        string DeleteDirector(int id);
        DirectorDto GetDirectorById(int id);
        List<DirectorDto> GetAllDirector();
    }
}
