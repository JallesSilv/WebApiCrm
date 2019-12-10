using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCrm.Models.Entidades;
using WebApiCrm.Models.Repository;

namespace WebApiCrm.Models.DAO
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ProductDbContext Contexto;

        public ClienteRepository(ProductDbContext contexto)
        {
            Contexto = contexto;
        }

        public void Editar(Cliente cliente)
        {
            Contexto.Cliente.Update(cliente);
            Contexto.SaveChanges();
        }

        public void Excluir(Cliente cliente)
        {
            Contexto.Cliente.Remove(cliente);
            Contexto.SaveChanges();
        }

        public void Iserir(Cliente cliente)
        {
            Contexto.Cliente.Add(cliente);
            Contexto.SaveChanges();
        }

        public Cliente Obter(int Chave_Cliente)
        {
            return Contexto.Cliente.Find(Chave_Cliente);
        }

        public IEnumerable<Cliente> Obter()
        {
            return Contexto.Cliente.ToList();
        }
    }
}
