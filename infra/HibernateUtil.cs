using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using fluentNhibernateAutoplay.infra.mapeamentos;
using NHibernate;

namespace fluentNhibernateAutoplay.infra
{
    public class HibernateUtil
    {
        public static ISessionFactory sessionFactory;
        
        public static ISession getSession()
        {
            sessionFactory = Fluently.Configure().Database(
                MySQLConfiguration.Standard.ConnectionString("Server=localhost;Port=3306;Database=nhibernate;Uid=root;Pwd=")
                .ShowSql()
                .FormatSql())
                .Mappings(m => { 
                    m.FluentMappings.AddFromAssemblyOf<ClientesMap>();
                })
                .BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}