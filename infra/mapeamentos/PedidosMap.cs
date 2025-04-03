using FluentNHibernate.Mapping;
using fluentNhibernateAutoplay.entidades;

namespace fluentNhibernateAutoplay.infra.mapeamentos
{
    public class PedidosMap : ClassMap<Pedido>
    {
        public PedidosMap()
        {
            Schema("nhibernate");
            Table("PEDIDO");
            Id(pedido => pedido.Id).Column("ID");
            Map(pedido => pedido.DataPedido).Column("DATAPEDIDO");
            Map(pedido => pedido.Cliente).Column("IDCLIENTE");
        }
    }
}