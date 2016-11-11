using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UniversalProject.DataModel;

namespace UniversalProject.ILogic
{
    public interface IUserLogic
    {
        List<User> GetAll();
    }
}
