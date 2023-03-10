using DevIO.Api.Controllers;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V2.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TesteController : MainController
    {
        public TesteController(INotificador notificador, IUser appUser) : base(notificador, appUser)
        {
        }

        [HttpGet]
        public string Valor()
        {
            return "Sou a V2";
        }
    }
}
