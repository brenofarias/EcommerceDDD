using ApplicationApp.Interface;
using Domain.Interfaces.InterfaceCompraUsuario;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces.InterfaceServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApplicationApp.OpenApp
{
    public class AppCompraUsuario : InterfaceCompraUsuarioApp
    {
        private readonly ICompraUsuario _IComprausuario;

        private readonly IServiceCompraUsuario _IServiceCompraUsuario;
        public AppCompraUsuario(ICompraUsuario ICompraUsuario, IServiceCompraUsuario IServiceCompraUsuario)
        {
            _IComprausuario = ICompraUsuario;
            _IServiceCompraUsuario = IServiceCompraUsuario;
        }

        public async Task<int> QuantidadeProdutoCarrinhoUsuario(string userId)
        {
            return await _IComprausuario.QuantidadeProdutoCarrinhoUsuario(userId);
        }

        public async Task<CompraUsuario> CarrinhoCompras(string userId)
        {
            return await _IServiceCompraUsuario.CarrinhoCompras(userId);
        }

        public async Task<CompraUsuario> ProdutosComprados(string userId)
        {
            return await _IServiceCompraUsuario.ProdutosCompra(userId);
        }

        public async Task<bool> ConfirmaCompraCarrinhoUsuario(string userId)
        {
            return await _IComprausuario.ConfirmaCompraCarrinhoUsuario(userId);
        }

        public async Task Add(CompraUsuario Objeto)
        {
            await _IComprausuario.Add(Objeto);
        }

        public async Task Delete(CompraUsuario Objeto)
        {
            await _IComprausuario.Delete(Objeto);
        }

        public async Task<CompraUsuario> GetEntityById(int Id)
        {
            return await _IComprausuario.GetEntityById(Id);
        }

        public async Task<List<CompraUsuario>> List()
        {
            return await _IComprausuario.List();
        }

        public async Task Update(CompraUsuario Objeto)
        {
            await _IComprausuario.Update(Objeto);
        }
    }
}
