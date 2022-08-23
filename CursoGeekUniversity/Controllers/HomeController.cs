using CursoGeekUniversity.Controllers.Base;
using CursoGeekUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CursoGeekUniversity.Controllers
{
    public class HomeController : BaseController
    {
        //Get
        public IActionResult Index()
        {
            return View();
        }
        //Get
        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacidade do Fabio";
            ViewBag.Nome = "Fabio";
            Mensagem("Info: Tela de privacidade", "info");
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(string Id, string Nome)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Mensagem("Erro: Insira um nome", "Error");
                return View();
            }
            return View("Index");
        }

        [Route("/Home/Mensagem/Saudacao/{nome}")]
        public IActionResult SaudacaoComNome(string nome)
        {
            return Content($"Olá usuário { nome } ");
        }

        public IActionResult Saudacao(int Id)
        {
            return Content($"Olá usuário { Id }");
        }
    }
}
