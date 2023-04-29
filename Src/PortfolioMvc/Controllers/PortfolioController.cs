using Microsoft.AspNetCore.Mvc;
using PortfolioMvc.Services;
using PortfolioMvc.ViewModels;
using Squidex.ClientLibrary;

namespace PortfolioMvc.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IProjetosService _projetoService;
        private readonly IEmailService _emailService;
        private readonly ILogger<PortfolioController> _logger;
        private readonly ISquidexClient _squidex;

        public PortfolioController(IProjetosService projetoService,
            IEmailService emailService,
            ISquidexClient squidex,
            ILogger<PortfolioController> logger)
        {
            _projetoService = projetoService;
            _emailService = emailService;
            _squidex = squidex;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var projetos = _projetoService.GetProjetos().Take(3).ToList();
            var result = _squidex.Schemas.GetSchemasAsync().Result;

            var modelo = new PortfolioViewModel()
            {
                Projetos = projetos
            };
            return View(modelo);
        }
        public IActionResult Projetos()
        {
            var projetos = _projetoService.GetProjetos();
            return View(projetos);
        }

        [HttpGet]
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contato(ContatoViewModel contatoViewModel)
        {
            await _emailService.Enviar(contatoViewModel);
            return RedirectToAction("Obrigado");
        }

        public IActionResult Obrigado()
        {
            return View();
        }
    }
}
