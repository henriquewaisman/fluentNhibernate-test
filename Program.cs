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
            
            IQueryable<Pedido> query = session.Query<Pedido>();

            query = query.Where(pedido => pedido.Cliente.Nome == "Ana");

            IList<Pedido> pedidos = query.ToList();

            foreach(var pedido in pedidos){
                Console.WriteLine(pedido.Id);
            }
            
            //Paginação
            query = query.Skip(10).Take(10).Where(p => p.Cliente.Nome == "Marcos");
            IList<Pedido> pedidos1 = query.ToList();

            transaction.Commit();
        }
    }
}