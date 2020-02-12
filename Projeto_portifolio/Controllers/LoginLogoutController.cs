using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoPortifolio.ModelContext;
using ProjetoPortifolio.Models;
using ProjetoPortifolio.RepositoryContext;
using ProjetoPortifolio.ViewModel;

namespace ProjetoPortifolio.Controllers
{
    public class LoginLogoutController : Controller
    {
        GeralModelContext contexto;
        LoginLogoutRepository contextoLoginLogout;

        public LoginLogoutController()
        {
            contexto = new GeralModelContext();
            contextoLoginLogout = new LoginLogoutRepository();
        }


        public IActionResult Index()
        {
           PortifolioViewModel dadosModel = new PortifolioViewModel();
            // Preeche view data do breadCrumb
            ViewData["ViewDataContent"] = "<li class=\"breadcrumb-item\"><a href=\"/Portifolio/pagina/1/_main\">Home</a></li><li class=\"breadcrumb-item active\" aria-current=\"page\">Login Manager</li>";
            dadosModel.botoes = contexto.getBotoesSite();
            return View("~/Views/Shared/Login/Login.cshtml", dadosModel);
        }


     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<object> loginManager()
        {
            ValidaUser dadosUser = new ValidaUser();
            object[] retorno = new object[2];
            dadosUser.usuario = HttpContext.Request.Form["usuario"];
            dadosUser.senha = HttpContext.Request.Form["senha"];

            //dadosUser.usuario = teste.
            var validaUser = contextoLoginLogout.verificaUser(dadosUser);
            if (validaUser != true)
            {
                retorno[0] = "Usuario ou senha incorretos , favor verificar os dados e tentar novamente !";
                retorno[1] = "";
                return retorno;
            }
            else
            {
                var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Name, dadosUser.usuario),
                            };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    IsPersistent = false,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30)
                    //RedirectUri = "_manager"

                    //AllowRefresh = <bool>,
                    // Refreshing the authentication session should be allowed.

                    //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                    // The time at which the authentication ticket expires. A 
                    // value set here overrides the ExpireTimeSpan option of 
                    // CookieAuthenticationOptions set with AddCookie.

                    //IsPersistent = true,
                    // Whether the authentication session is persisted across 
                    // multiple requests. When used with cookies, controls
                    // whether the cookie's lifetime is absolute (matching the
                    // lifetime of the authentication ticket) or session-based.

                    //IssuedUtc = <DateTimeOffset>,
                    // The time at which the authentication ticket was issued.

                    //RedirectUri = <string>
                    // The full path or absolute URI to be used as an http 
                    // redirect response value.
                };

              await  HttpContext.SignInAsync(
                            scheme: "FiverSecurityScheme",
                            principal: principal
                        );

                retorno[0] = "";
                retorno[1] = "ok";
            }

            return retorno;
        }

        // Logout do sistema
        public async Task<IActionResult> logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync("FiverSecurityScheme");
            }
            return Redirect("login");
        }



    }
}