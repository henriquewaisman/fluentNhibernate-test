using fluentNhibernateAutoplay.entidades;
using fluentNhibernateAutoplay.infra;
using NHibernate;

namespace fluentNhibernateAutoplay
{
    static class Program
    {
        static void Main(string[] args)
        {
            ISession session = HibernateUtil.getSession();
            ITransaction transaction = session.BeginTransaction();
            
            Cliente cliente = session.Get<Cliente>(1);

            Produto produto = new Produto("Coca", 8);
            Produto produto1 = new Produto("Alfajor", 9.5f);
            Produto produto2 = new Produto("Doce de Leite", 2.45f);

            IList<Produto> produtos = new List<Produto>();
            produtos.Add(produto);
            produtos.Add(produto1);
            produtos.Add(produto2);

            session.Save(produto);
            session.Save(produto1);
            session.Save(produto2);

            Pedido pedido = new Pedido(cliente, produtos);

            session.Save(pedido);
            
            // Pedido pedido1 = session.Get<Pedido>(11);

            // var itens = pedido1.Produtos;

            // Console.WriteLine($"A quantidade de itens no pedido {pedido1.Id} é {itens.Count()}:");
            // foreach(var item in itens)
            // {
            //     Console.WriteLine($"{item.Id} - {item.Nome}");
            // }

            transaction.Commit();
        }
    }
}