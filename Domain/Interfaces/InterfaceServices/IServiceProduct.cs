using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IServiceProduct
    {
        // Criado os metodos de adicionar e atualizar pois terá validações especificas
        Task AddProduct(Produto produto);
        Task UpdateProduct(Produto produto);
    }
}
