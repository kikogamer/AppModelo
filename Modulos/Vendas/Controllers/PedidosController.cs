using Kiko.UI.Site.Modulos.Vendas.Data;
using Microsoft.AspNetCore.Mvc;

namespace Kiko.UI.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    public class PedidosController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidosController(IPedidoRepository pedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;
        }
        public IActionResult Index()
        {
            return View(this._pedidoRepository);
        }
    }
}