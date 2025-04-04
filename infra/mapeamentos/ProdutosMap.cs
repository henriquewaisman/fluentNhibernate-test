using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using fluentNhibernateAutoplay.entidades;
using MySqlX.XDevAPI;

namespace fluentNhibernateAutoplay.infra.mapeamentos
{
    public class ProdutosMap : ClassMap<Produto>
    {
        public ProdutosMap()
        {
            Schema("nhibernate");
            Table("produto");
            Id(produto => produto.Id).Column("ID");
            Map(produto => produto.Nome).Column("NOME");
            Map(produto => produto.Preco).Column("PRECO");
        }

    }
}