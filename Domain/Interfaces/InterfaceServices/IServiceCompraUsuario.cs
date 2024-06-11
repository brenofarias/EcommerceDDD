using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IServiceCompraUsuario
    {
        public Task<CompraUsuario> CarrinhoCompras(string userId);

        public Task<CompraUsuario> ProdutosCompra(string userId);
    }
}
