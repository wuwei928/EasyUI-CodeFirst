using System.Collections.Generic;
using System.Linq;
using UniversalProject.DataModel;
using UniversalProject.ILogic;
using UniversalProject.IRepository;

namespace UniversalProject.Logic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserRepository _userRepository;

        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll().ToList();
        }
    }
}
