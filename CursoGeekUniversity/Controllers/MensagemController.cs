using CursoGeekUniversity.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoGeekUniversity.Controllers
{
    public class MensagemController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MensaagemBemvindo()
        {
            return View();
        }
    }
}
