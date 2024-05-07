using ApplicationApp.Interface;
using Domain.Interfaces.InterfaceCompraUsuario;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApplicationApp.OpenApp
{
    public class AppCompraUsuario : InterfaceCompraUsuarioApp
    {
        private readonly ICompraUsuario _IComprausuario;
        public AppCompraUsuario(ICompraUsuario ICompraUsuario)
        {
            _IComprausuario = ICompraUsuario;
        }

        public async Task<int> QuantidadeProdutoCarrinhoUsuario(string userId)
        {
            return await _IComprausuario.QuantidadeProdutoCarrinhoUsuario(userId);
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
