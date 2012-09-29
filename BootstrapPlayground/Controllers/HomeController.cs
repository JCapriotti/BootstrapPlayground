using System.Web.Mvc;

namespace BootstrapPlayground.Controllers
{
	public partial class HomeController : Controller
	{
		//
		// GET: /Home/

		public virtual ActionResult Index()
		{
			return View();
		}

	}
}
