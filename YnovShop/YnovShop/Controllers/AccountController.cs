using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using YnovShop.Business;
using YnovShop.Models;

namespace YnovShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILogger _logger;

        public AccountController(ILogger<AccountController> logger,
            IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: Account/Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                _userService.CreateUser(
                    model.Firstname,
                    model.Lastname,
                    model.Email,
                    model.Password);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
                ModelState.AddModelError("Erreur", "Une erreur est survenue pendant l'enregistrement");
                return BadRequest(ModelState);
            }
         }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            return RedirectToAction("Index");
        }
    }
}