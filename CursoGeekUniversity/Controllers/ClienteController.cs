using CursoGeekUniversity.Controllers.Base;
using CursoGeekUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoGeekUniversity.Controllers
{
    public class ClienteController : BaseController
    {
        public IActionResult Index()
        {
            List<ClienteViewModel> listCliente = new List<ClienteViewModel>()
            {
                new ClienteViewModel() { Nome = "Fabio", Endereço = "", Telefone = "123"},
                new ClienteViewModel() { Nome = "Carlos", Endereço = "", Telefone = "456"}
            };
            return View(listCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)               
            {
                List<ClienteViewModel> listCliente = new List<ClienteViewModel>();
                listCliente.Add(cliente);
                Mensagem("Cliente salvo com sucesso", "Success");
                return View("Index", listCliente);
            }
            return View(cliente);
        }
        public IActionResult Details(string nome)
        {
            return View();
        }
    }
}
