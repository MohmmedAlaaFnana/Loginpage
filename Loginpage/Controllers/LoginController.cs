using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loginpage.Models;

namespace Loginpage.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public List<Usermodel1> PutValue()
        {
            var users = new List<Usermodel1>
            {
                new Usermodel1{Id=1,username="amitkumar",password="abc123"},
                new Usermodel1{Id=2,username="lisa",password="xyz546"},
                new Usermodel1{Id=3,username="virat",password="pnpc465"},
                new Usermodel1{Id=4,username="trina",password="urt324"},

            };
            return users;
        }
        [HttpPost]
        public IActionResult Verify(Usermodel1 usr)
        {
            var u = PutValue();
            var ue = u.Where(u => u.username.Equals(usr.username));
            var up = u.Where(u => u.password.Equals(usr.password));
            if (up.Count() == 1)
            {
                ViewBag.message = "Login Success";

                return View("LoginSucess");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Login");
            }
        }
    }
}
