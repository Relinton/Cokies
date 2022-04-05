using CokieAspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CokieAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastrarCookies(string cookiename, string cookievalue, bool IsPersistent)
        {
            CookieOptions cookies = new CookieOptions();
            cookies.Expires = DateTime.Now.AddDays(1);
            if (IsPersistent)
            {
                Response.Cookies.Append(cookiename, cookievalue, cookies);
            }
            else
            {
                Response.Cookies.Append(cookiename, cookievalue);
            }
            ViewBag.message = "Cookies adicionados com sucesso";
            return View("Index");
        }

        public IActionResult LerCookies()
        {
            ViewBag.cookievalue = Request.Cookies["UserName"];

            return View();
        }







        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }










        //Criando a opção dois para cookie
        public IActionResult Criar()
        {
            /*
             *if (Request.Cookies["nome"] != null)
            {
                ViewBag.message = "O cookie foi salvo com sucesso";
            }
            else
            {
                ViewBag.message = "Não avaliado";
            }
             */
            return View();
        }

        [HttpPost]
        public IActionResult Criar(IFormCollection fc, int opcao)
        {
            if (opcao == 1)
            {
                CookieOptions opcoes = new CookieOptions();
                opcoes.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Append("nome", fc["opcao"], opcoes);
                ViewBag.message = "Você escolheu a opção Péssimo";
            }
            else if (opcao == 2)
            {
                CookieOptions opcoes = new CookieOptions();
                opcoes.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Append("nome", fc["opcao"], opcoes);
                ViewBag.message = "Você escolheu a opção Ruim";
            }
            else if (opcao == 3)
            {
                CookieOptions opcoes = new CookieOptions();
                opcoes.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Append("nome", fc["opcao"], opcoes);
                ViewBag.message = "Você escolheu a opção Indiferente";

            }
            else if (opcao == 4)
            {
                CookieOptions opcoes = new CookieOptions();
                opcoes.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Append("nome", fc["opcao"], opcoes);
                ViewBag.message = "Você escolheu a opção Bom";
            }
            else
            {
                CookieOptions opcoes = new CookieOptions();
                opcoes.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Append("nome", fc["opcao"], opcoes);
                ViewBag.message = "Você escolheu a opção Ótimo";
            }
            return RedirectToAction("Resultado", "Home");
        }

        public IActionResult Resultado()
        {
            return View();
        }

        public ActionResult Excluir()
        {
            if (Request.Cookies["nome"] != null)
            {
                Response.Cookies.Delete("nome");
            }
            return RedirectToAction("Criar", "Home");
        }

    }
}
