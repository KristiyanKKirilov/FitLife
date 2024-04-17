using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FitLife.GlobalConstants.AdminConstants;
namespace FitLife.Web.Areas.Admin.Controllers
{
    [Area(AdminArea)]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
        
    }
}
