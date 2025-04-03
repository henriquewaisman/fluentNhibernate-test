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

            // Cliente cliente = new Cliente("Marcos", "marcos@mail.com", "marcosSenha");
            // session.Save(cliente);

            // Cliente cliente1 = session.Get<Cliente>(1);
            // cliente.Nome = "Henrique";
            // cliente.Email = "henrique@gmail.com";
            // session.Update(cliente1);

            Cliente cliente2 = session.Get<Cliente>(4);
            session.Delete(cliente2);
            transaction.Commit();
        }
    }
}