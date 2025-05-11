using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula08_JSON.View
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            this.FormClosing += Principal_FormClosing;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false; // Oculta o formulário atual
            Forms_Json forms_Json = new Forms_Json();
            forms_Json.Show(); // Exibe o novo formulário

        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Visible = false; // Oculta o formulário atual
            Form1 form1 = new Form1();
            form1.Show(); // Exibe o novo formulário

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Fecha a aplicação
        }
    }
}
