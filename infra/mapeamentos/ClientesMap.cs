using FluentNHibernate.Mapping;
using fluentNhibernateAutoplay.entidades;

namespace fluentNhibernateAutoplay.infra.mapeamentos
{
    public class ClientesMap : ClassMap<Cliente>
    {
        public ClientesMap()
        {
            Schema("nhibernate");
            Table("CLIENTE");
            Id(cliente => cliente.Id).Column("ID");
            Map(cliente => cliente.Nome).Column("NOME");
            Map(cliente => cliente.Email).Column("EMAIL");
            Map(cliente => cliente.Senha).Column("SENHA");
            HasMany(cliente => cliente.Pedidos).KeyColumn("IDCLIENTE");
        }
    }
}