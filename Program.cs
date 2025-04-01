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

            Cliente cliente = new Cliente("fulano", "fulando@gmail.com", "senhaFulano");

            session.Save(cliente);
        }
    }
}