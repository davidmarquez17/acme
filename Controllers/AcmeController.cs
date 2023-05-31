using acme_api_rest.Models;
using Microsoft.AspNetCore.Mvc;

namespace acme_api_rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcmeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<EnviarPedidoResponse>> Get(EnviarPedidoRequest enviarPedidoRequest)
        {            
            return Ok(new EnviarPedidoResponse
            {
                codigo = 80375472,
                estado = "Entregado exitosamente al cliente"
            });
        }
    }
}