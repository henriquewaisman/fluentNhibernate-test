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


            Cliente cliente1 = session.Get<Cliente>(1);
            cliente1.Nome = "Henrique";
            session.Update(cliente1);
        }
    }
}