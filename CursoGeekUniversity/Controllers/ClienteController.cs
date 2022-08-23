using CursoGeekUniversity.Controllers.Base;
using CursoGeekUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using CursoGeekUniversity.Models.ModeloDados;

namespace CursoGeekUniversity.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly IMapper _mapper;

        public ClienteController(IMapper mapper)
        {
            _mapper = mapper;
        }
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
            var cliente = new ClienteModel() 
            { CPF = "1", Endereço = "a", Id = "1", Nome = "Carlos", NumeroCartaoCredito = "1", Telefone = "1" };

            var clienteVM = _mapper.Map<ClienteViewModel>(cliente);

            return View(clienteVM);
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
