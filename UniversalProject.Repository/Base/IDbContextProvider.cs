using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalProject.DAO;

namespace UniversalProject.Repository.Base
{
    public interface IDbContextProvider
    {
        ProjectDbContext CurrentDbContext();
    }
}
