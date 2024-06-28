using Sever.Dto.Actor;
using Sever.Dto.Director;

namespace Sever.Services.Directors
{
    public interface IDirectorService
    {
        DirectorDto AddDirector(CreateDirectorDto createDirectorDto);
        DirectorDto UpdateDirector(int id, UpdateDirectorDto updateDirectorDto);
        string DeleteDirector(int id);
        DirectorDto GetDirectorById(int id);
        List<DirectorDto> GetAllDirector();
    }
}
