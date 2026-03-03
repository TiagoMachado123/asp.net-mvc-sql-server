using Microsoft.AspNetCore.Mvc;
using teste.Services;

namespace teste.Controllers
{
    public class FaturasController : Controller
    {
        private readonly IFaturaService _faturaService;

        // Injetamos o nosso Serviço no Controller (tal como fazias no NestJS!)
        public FaturasController(IFaturaService faturaService)
        {
            _faturaService = faturaService;
        }

        // A Action (função) que vai responder quando fores a /Faturas
        public IActionResult Index()
        {
            // 1. Pede ao serviço para ir à base de dados buscar as faturas
            var listaDeFaturas = _faturaService.ObterTodas();

            // 2. Entrega as faturas à View (o HTML)
            return View(listaDeFaturas);
        }
    }
}
