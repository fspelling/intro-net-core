using DependencyCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DependencyCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Mensagem { get; set; }

        public void OnGet([FromServices]IEmailService emailService)
        {
            Mensagem = emailService.Enviar();

            _logger.LogDebug("uma mensagem");
            _logger.LogWarning("uma mensagem warning");
            _logger.LogError("uma mensagem error");
        }
    }
}
