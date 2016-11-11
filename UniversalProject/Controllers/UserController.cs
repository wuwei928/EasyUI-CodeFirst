using System.Linq;
using System.Web.Mvc;
using UniversalProject.ILogic;
using UniversalProject.Mapper.DataModelToViewModel;
using UniversalProject.ViewModel;

namespace UniversalProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserLogic _userLogic;

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User
        public ActionResult GetUser()
        {
            var users = _userLogic.GetAll().Select(x => x.ToViewModel()).ToList();
            var userJson = new
            {
                rows = users
            };
            return Json(userJson, JsonRequestBehavior.AllowGet);
        }
    }
}