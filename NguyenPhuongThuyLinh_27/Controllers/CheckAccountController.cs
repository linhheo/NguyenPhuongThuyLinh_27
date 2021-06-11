using NguyenPhuongThuyLinh_27.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NguyenPhuongThuyLinh_27.Controllers
{
    public class CheckAccountController : Controller
    {
		public ViewResult Login(string returnUrl)
		{
			ViewBag.returnUrl = returnUrl;
			return View();
		}

		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public ActionResult Login(CheckAccount acc, string returnUrl)
		{
			if (ModelState.IsValid)
			{
				if (acc.CheckUsername == "Admin" && acc.CheckPassword == "123456")
				{
					FormsAuthentication.SetAuthCookie(acc.CheckPassword, true);
					return RedirectToLocal(returnUrl);
				}
			}
			return View(acc);
		}
		public ActionResult Logoff()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Index", "Home");
		}
		private ActionResult RedirectToLocal(string returnUrl)
		{
			if (Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}
	}
}