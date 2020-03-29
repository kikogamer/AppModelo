using Kiko.UI.Site.Modulos.Vendas.Models;

namespace Kiko.UI.Site.Modulos.Vendas.Data
{
  public class PedidoRepository : IPedidoRepository
  {
    public Pedido ObterPedido()
    {
      return new Pedido();
    }
  }

  public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}