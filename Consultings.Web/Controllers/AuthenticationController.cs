using AutoMapper;
using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using ServiceLayer.Helpers.Identity;

namespace Consultings.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IValidator<SignUpVM> _signUpValidator;
        private readonly IValidator<LogInVM> _logInVMValidator;
        private readonly IMapper _imapper;

        public AuthenticationController(UserManager<AppUser> userManager, IValidator<SignUpVM> signUpValidator, IMapper imapper, IValidator<LogInVM> logInVMValidator, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signUpValidator = signUpValidator;
            _imapper = imapper;
            _logInVMValidator = logInVMValidator;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpVM request)
        {
            var Validation = await _signUpValidator.ValidateAsync(request);
            if(Validation.IsValid)
            {
                ViewBag.Result = "NotSucceed";
                Validation.AddToModelState(this.ModelState);
                return View();
            }
            var user = _imapper.Map<AppUser>(request);
            var userCreateResult = await _userManager.CreateAsync(user, request.Password);
            if(userCreateResult.Succeeded)
            {
                ViewBag.Result = "NotSucceed";
                ModelState.AddModelErrorList(userCreateResult.Errors);
                return View();
            }
            return RedirectToAction("LogIn", "Authentication");
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LogInVM request, string? returnUrl=null)
        {
            returnUrl = returnUrl ?? Url.Action("Index", "Dashboard", new {Area = "Admin"});
            var validation = await _logInVMValidator.ValidateAsync(request);
            if (!validation.IsValid)
            {
                ViewBag.Result = "NotSucceed";
                validation.AddToModelState(this.ModelState);
                return View();
            }
            var hasUser = await _userManager.FindByEmailAsync(request.Email);
            if (hasUser == null)
            {
                ViewBag.Result = "NotSucceed";
                ModelState.AddModelErrorList(new List<string> { "Email or Password is wrong" });
                return View();
            }
            var logInResult = await _signInManager.PasswordSignInAsync(hasUser, request.Password,request.RememberMe,true);
            if (logInResult.Succeeded)
            {
                return RedirectToAction(returnUrl!); 
            }
            if (logInResult.IsLockedOut)
            {
                ViewBag.Result = "LockedOut";
                ModelState.AddModelErrorList(new List<string> { "your account is locked Out for 60 Seconds!" });
                return View();
            }
            ViewBag.Result = "FailedAttempt";
            ModelState.AddModelErrorList(new List<string> { $"Email or Password is wrong! Filed attempt{ await
                    _userManager.GetAccessFailedCountAsync(hasUser)}" });
            return View();
        }
    }
}
