using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Models;
using Tarefas.Services;

namespace Tarefas.Controllers
{
    
    public class TarefasController : Controller
    {
        ITarefaItemService _tarefaService;
        public TarefasController(ITarefaItemService tarefaService)
        {
            _tarefaService = tarefaService;
        }


        // lista de tarefas
        public IActionResult Index()
        {            
            // obter os dados e retornar            
            //TempTarefaItemService servico = new TempTarefaItemService();
            //var tarefas = servico.GetItemAsync();
            //return View(tarefas);

            // obter os dados e retornar            
            var tarefas = _tarefaService.GetItemAsync();
            return View(tarefas);            
        }
    }
}
