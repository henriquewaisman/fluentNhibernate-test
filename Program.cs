using System;
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

            // Cliente cliente = new Cliente("Luis", "luis@mail.com", "senhaLuis");
            // Cliente cliente1 = new Cliente("Marcos", "marcos@mail.com", "senhaMarcos");
            // Cliente cliente2 = new Cliente("Joao", "joao@mail.com", "senhaJoao");
            // Cliente cliente3 = new Cliente("Maria", "maria@mail.com", "senhaMaria");
            // Cliente cliente4 = new Cliente("Ana", "ana@mail.com", "senhaAna");

            // session.Save(cliente);
            // session.Save(cliente1);
            // session.Save(cliente2);
            // session.Save(cliente3);
            // session.Save(cliente4);


            Cliente cliente = session.Get<Cliente>(1);
            Cliente cliente1 = session.Get<Cliente>(2);
            Cliente cliente2 = session.Get<Cliente>(3);
            Cliente cliente3 = session.Get<Cliente>(4);
            Cliente cliente4 = session.Get<Cliente>(5);

            Pedido pedido = new Pedido(cliente);
            Pedido pedido1 = new Pedido(cliente1);
            Pedido pedido2 = new Pedido(cliente2);
            Pedido pedido3 = new Pedido(cliente3);
            Pedido pedido4 = new Pedido(cliente4);

            session.Save(pedido);
            session.Save(pedido1);
            session.Save(pedido2);
            session.Save(pedido3);
            session.Save(pedido4);
            
            transaction.Commit();
        }
    }
}