using Domain.Interfaces.InterfaceCompraUsuario;
using Entities.Entities;
using Infraestructure.Configuration;
using Infraestructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Repositories
{
    public class RepositoryCompraUsuario : RepositoryGenerics<CompraUsuario>, ICompraUsuario
    {
        private readonly DbContextOptions<ContextBase> _optionsbuilder;

        public RepositoryCompraUsuario()
        {
            _optionsbuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<int> QuantidadeProdutoCarrinhoUsuario(string userId)
        {
            using (var banco = new ContextBase(_optionsbuilder))
            {
                // Retorna a quantidade de produtos que o usuário tem no carrinho
                return await banco.CompraUsuario.CountAsync(c => c.UserID.Equals(userId));
            }
        }
    }
}
