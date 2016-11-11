using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversalProject.DataModel;
using UniversalProject.ViewModel;

namespace UniversalProject.Mapper.DataModelToViewModel
{
    public static class UserViewModelAdapter
    {
        public static UserViewModel ToViewModel(this User user)
        {
            var userViewModel = new UserViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone
            };
            
            return userViewModel;
        }
    }
}