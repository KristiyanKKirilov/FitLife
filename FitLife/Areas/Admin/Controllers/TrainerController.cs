using Microsoft.AspNetCore.Mvc;

namespace FitLife.Web.Areas.Admin.Controllers
{
	public class TrainerController : AdminBaseController
	{
		public IActionResult Hire()
		{
			return View();
		}
	}
}
