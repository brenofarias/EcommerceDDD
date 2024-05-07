using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceProduct
{
    // Ele herda os metódos de Generic passando a entidade Produto
    public interface IProduct : IGeneric<Produto>
    {
        Task<List<Produto>> ListarProdutosUsuario(string userID);

        Task<List<Produto>> ListarProdutos(Expression<Func<Produto, bool>> exProduto);

        Task<List<Produto>> ListarProdutosCarrinhoUsuario(string userId);

        Task<Produto> ObterProdutoCarrinho(int idProdutoCarrinho);
    }
}
