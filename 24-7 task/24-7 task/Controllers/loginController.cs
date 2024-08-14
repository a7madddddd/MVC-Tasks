using System.Web.Mvc;

public class AccountController : Controller
{
    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Login(string email, string password)
    {
        if (email == "onizata3@gmail.com" && password == "123")
        {
            Session["User"] = email;
            return RedirectToAction("Index", "Home");
        }
        ViewBag.Message = "Invalid login attempt";
        return View();
    }

    public ActionResult Logout()
    {
        Session["User"] = null;
        return RedirectToAction("Index", "Home");
    }
}
