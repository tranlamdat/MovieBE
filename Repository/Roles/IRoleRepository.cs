using Sever.Models;

namespace Sever.Repository.Roles
{
    public interface IRoleRepository
    {
        void CreateRole(Role role);
        Role GetRoleByName(string name);
        Role GetRoleById(int id);
        void UpdateRole(Role role);
        void DeleteRole(Role role);
        List<Role> GetRoles();
    }
}
