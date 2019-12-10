using System.Collections.Generic;
using WebApiCrm.Models.Entidades;

namespace WebApiCrm.Models.Repository
{
    public interface IClienteRepository
    {
        void Iserir(Cliente cliente);

        void Editar(Cliente cliente);

        void Excluir(Cliente cliente);

        Cliente Obter(int Chave_Cliente);

        IEnumerable<Cliente> Obter();
    }
}
