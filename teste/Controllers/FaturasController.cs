using Microsoft.AspNetCore.Mvc;
using teste.Services;

namespace teste.Controllers
{
    public class FaturasController : Controller
    {
        private readonly IFaturaService _faturaService;

        public FaturasController(IFaturaService faturaService)
        {
            _faturaService = faturaService;
        }

        public IActionResult Index()
        {
            // 1. Pede ao serviço para ir à base de dados buscar as faturas
            var listaDeFaturas = _faturaService.ObterTodas();

            return View(listaDeFaturas);
        }
    }
}
