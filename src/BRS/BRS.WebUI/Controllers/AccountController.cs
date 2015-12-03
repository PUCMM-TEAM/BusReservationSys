using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BRS.Core.Models;
using BRS.Logical.Account;
using BRS.WebUI.Models;

namespace BRS.WebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View(new LoginUserViewModel());
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "username,password")] LoginUserViewModel vmModel) {

          if (ModelState.IsValid){
            if (UserSessionManager.Instance.LoginUser(vmModel.Username, vmModel.Password)) {
              return RedirectToAction("Admin", "Home");
            }
          }

          return View(vmModel);
        }

      public ActionResult Register(){
        NewUserViewModel vmModel = new NewUserViewModel();
        return View(vmModel);
      }

      [HttpPost]
      public ActionResult Register(NewUserViewModel vmModel){

        if (ModelState.IsValid) {
          User user = new User {
            ID = 0,
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now,
            Deleted = false,
            Username = vmModel.Username,
            Password = vmModel.Password,
            Email = vmModel.Email
          };

        }

        return View(vmModel);
      }
    }
}