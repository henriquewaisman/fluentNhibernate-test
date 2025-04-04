using System;
using fluentNhibernateAutoplay.entidades;
using fluentNhibernateAutoplay.infra;
using NHibernate;

namespace fluentNhibernateAutoplay
{
    static class Anotacao
    {
        static void MainAnotacao()
        {
            ISession session = HibernateUtil.getSession();
            ITransaction transaction = session.BeginTransaction();

            //Instancia o cliente com os atributos de insere na tabela usando .Save
            Cliente cliente = new Cliente("Marcos", "marcos@mail.com", "marcosSenha");
            session.Save(cliente);

            
            //Instancia um novo objeto para recuperar pelo Id na tabela usando Get
            Cliente cliente1 = session.Get<Cliente>(1);
            cliente.Nome = "Henrique";
            cliente.Email = "henrique@gmail.com";
            //Altera as informações Nome e Email do Cliente de Id 1 usando .Update
            session.Update(cliente1);
            

            //Instancia mais um objeto recuperando o Cliente por Id e deleta a linha da tabela usando .Delete
            Cliente cliente2 = session.Get<Cliente>(4);
            session.Delete(cliente2);
            
            //Para update e delete é necessário commitar usando uma interface transaction
            transaction.Commit();
        }
    }
}