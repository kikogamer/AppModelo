using System;

namespace Kiko.UI.Site.Modulos.Vendas.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public Pedido()
        {
            this.Id = Guid.NewGuid();
        }
    }
}