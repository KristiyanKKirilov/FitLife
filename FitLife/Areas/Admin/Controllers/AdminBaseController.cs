using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FitLife.GlobalConstants.RoleConstants;
namespace FitLife.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
        
    }
}
