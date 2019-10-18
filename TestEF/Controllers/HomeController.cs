using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestEF.Models;
using TestEF.Services;

namespace TestEF.Controllers
{
    
    public class HomeController : Controller
    {
        //private readonly  IDataService _injectedserviceinstance;

        //public HomeController(IDataService injectedDataService)
        //{
        //    _injectedserviceinstance = injectedDataService;
        //}

        
        public IActionResult Index()
        {
            //var listaProductos = _injectedserviceinstance.GetAll();
            //return View(listaProductos);
            return View();
        }

        public string Dinject([FromServices] IDataService injectedDataService)
        {
            var listaPersonas = injectedDataService.GetAll();
            return "Conteo de Personas = " + listaPersonas.Count.ToString();
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
    }
}
