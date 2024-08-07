using BlazorClienteNet8.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClienteNet8.Shared.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente> AddClienteAsync(Cliente model);
        Task<Cliente> UpdateClienteAsync(Cliente model);
        Task<Cliente> DeleteClienteAsync(int clienteId);
        Task<List<Cliente>> GetAllClientesAsync();
        Task<Cliente> GetClienteByIdAsync(int clienteId);
    }
}
