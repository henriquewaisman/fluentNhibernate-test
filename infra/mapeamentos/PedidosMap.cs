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
            References(pedido => pedido.Cliente).Column("IDCLIENTE");
            HasManyToMany(pedido => pedido.Produtos)
            .Table("itemproduto")
            .ParentKeyColumn("IDPEDIDO")
            .ChildKeyColumn("IDPRODUTO")
            .Cascade.All();
            /*
            Id maps PK
            Map maps Attributes
            References maps FK

            HasManyToMany maps List<> (n:n)
            .HasManyToMany(List<>)
            .Table(Intermediária)
            .ParentKeyColumn(IdPai)
            .ChuldKeyColumn(IdFilho)
            .Cascade.All() -> Por se tratar de uma tabela intermediária (itempedido),
            faz sentido subordinar o update e delete às tabelas "pai"
            */
        }
    }
}