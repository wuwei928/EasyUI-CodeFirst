using UniversalProject.DataModel;
using UniversalProject.IRepository;
using UniversalProject.Repository.Base;

namespace UniversalProject.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IDbContextProvider dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
