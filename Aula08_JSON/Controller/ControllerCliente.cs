using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula08_JSON.Model;
using System.Text.Json;

namespace Aula08_JSON.Controller
{
    internal class ControllerCliente
    {
        private string arquivoCaminho = "cliente.json";
        private List<Cliente> clientes = new List<Cliente>();
        

     

        public List<Cliente> CarregarDados()
        {

            if (File.Exists(arquivoCaminho))
            {
                string json = File.ReadAllText(arquivoCaminho);
                clientes = JsonSerializer.Deserialize<List<Cliente>>(json)?? new List<Cliente>();
                
            }

            return clientes;
        }

        public void CadastrarCliente(string nome, string email, int idade)
        {
            int novoId = clientes.Count > 0 ? clientes[clientes.Count - 1].ID+1 :0;

            clientes.Add(new Cliente
            {
                ID = novoId,
                Nome = nome,
                Email = email,
                Idade = idade
                
            });
            SalvarDados();
                

                


        }
        private void SalvarDados()
        {
            string json = JsonSerializer.Serialize(clientes);
            File.WriteAllText(arquivoCaminho, json);
        }

        public string RemoverLista(int id)
        {
            Cliente clienteParaRemover = clientes.FirstOrDefault(cl => cl.ID == id);
            if (clienteParaRemover != null)
            {
                Remover(clienteParaRemover);
                SalvarDados(); // É importante salvar os dados após a remoção
                return "Removido";
            }
            return "Cliente não encontrado";
        }

        public void Remover(Cliente cliente)
        {
            
            clientes.Remove(cliente);
        }



    }
}
