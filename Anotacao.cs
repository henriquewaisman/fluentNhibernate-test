using System;
using fluentNhibernateAutoplay.entidades;
using fluentNhibernateAutoplay.infra;
using NHibernate;

namespace fluentNhibernateAutoplay
{
    static class Anotacao
    {
        static void Estudo()
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
        
            /*
            // População
            Cliente cliente = new Cliente("Luis", "luis@mail.com", "senhaLuis");
            Cliente cliente1 = new Cliente("Marcos", "marcos@mail.com", "senhaMarcos");
            Cliente cliente2 = new Cliente("Joao", "joao@mail.com", "senhaJoao");
            Cliente cliente3 = new Cliente("Maria", "maria@mail.com", "senhaMaria");
            Cliente cliente4 = new Cliente("Ana", "ana@mail.com", "senhaAna");

            session.Save(cliente);
            session.Save(cliente1);
            session.Save(cliente3);
            session.Save(cliente4);
            session.Save(cliente2);


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
            */

            // Pedido pedido1 = session.Get<Pedido>(11);

            // var itens = pedido1.Produtos;

            // Console.WriteLine($"A quantidade de itens no pedido {pedido1.Id} é {itens.Count()}:");
            // foreach(var item in itens)
            // {
            //     Console.WriteLine($"{item.Id} - {item.Nome}");
            // }

        }
    }
}