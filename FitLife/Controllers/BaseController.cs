using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitLife.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {     
       
    }
}
