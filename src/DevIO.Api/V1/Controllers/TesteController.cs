using DevIO.Api.Controllers;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TesteController : MainController
    {
        private readonly ILogger<TesteController> _logger;
        public TesteController(INotificador notificador,
            IUser appUser,
            ILogger<TesteController> logger) : base(notificador, appUser)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Valor()
        {
            //throw new Exception("Error");
            //try
            //{
            //    var i = 0;
            //    var result = 42 / i;
            //}
            //catch (DivideByZeroException e)
            //{
            //    e.Ship(HttpContext);
            //}
            _logger.LogTrace("Log de Trace"); //Menos relevante
            _logger.LogDebug("Log de Debug"); //Para debug, durante desenvolvimento
            _logger.LogInformation("Log de informação");
            _logger.LogWarning("Log de Aviso");
            _logger.LogError("Log de Erro");
            _logger.LogCritical("Log de problema crítico");
            return "Sou a V1";
        }
    }
}
