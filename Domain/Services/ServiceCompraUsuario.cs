﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces.InterfaceCompraUsuario;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using Entities.Entities.Enums;

namespace Domain.Services
{
    public class ServiceCompraUsuario : IServiceCompraUsuario
    {
        private readonly ICompraUsuario _ICompraUsuario;

        public ServiceCompraUsuario(ICompraUsuario ICompraUsuario)
        {
            _ICompraUsuario = ICompraUsuario;
        }

        public async Task<CompraUsuario> CarrinhoCompras(string userId)
        {
            return await _ICompraUsuario.ProdutosCompradosPorEstado(userId, EnumEstadoCompra.Produto_Carrinho);
        }

        public async Task<CompraUsuario> ProdutosCompra(string userId)
        {
            return await _ICompraUsuario.ProdutosCompradosPorEstado(userId, EnumEstadoCompra.Produto_Comprado);
        }
    }
}
