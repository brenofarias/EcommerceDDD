using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interface
{
    public interface InterfaceCompraUsuarioApp : InterfaceGenericApp<CompraUsuario>
    {
        public Task<int> QuantidadeProdutoCarrinhoUsuario(string userId);

        public Task<CompraUsuario> CarrinhoCompras(string userId);

        public Task<CompraUsuario> ProdutosComprados(string userId);

        public Task<bool> ConfirmaCompraCarrinhoUsuario(string userId);

    }
}
