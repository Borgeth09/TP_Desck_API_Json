using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula08_JSON.Model;
using System.Text.Json;

namespace Aula08_JSON.View
{
    public partial class Forms_Json : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        public Forms_Json()
        {
            InitializeComponent();
            dgv_Mostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta o tamanho das colunas
            this.FormClosed += Forms_Json_FormClosed;
        }

        private void btn_Obter_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private async void Buscar()
        {
            string url = "https://fakestoreapi.com/users";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(url);

                    List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

                    dgv_Mostrar.DataSource = usuarios;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }

        // Corrigido o tipo de evento para corresponder ao FormClosedEventHandler
        private void Forms_Json_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Fecha a aplicação
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Visible = false; // Oculta o formulário atual
            Form_Principal principal = new Form_Principal(); // Cria uma nova instância do Form1
            principal.Show(); // Exibe o Form1
            principal.FormClosed += (s, args) => this.Close(); // Fecha o Forms_Json quando o Form1 for fechado

        }
    }
}

