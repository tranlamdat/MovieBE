using Sever.Models;

namespace Sever.Repository.Directors
{
    public interface IDirectorRepository
    {
        void CreateDirector(Director director);
        Director GetDirectorById(int id);
        void UpdateDirector(Director director);
        void DeleteDirector(Director director);
        List<Director> GetAllDirector();
    }
}
