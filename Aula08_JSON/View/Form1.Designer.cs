namespace Aula08_JSON
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.dgv_Mostrar = new System.Windows.Forms.DataGridView();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_Idade = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(16, 222);
            this.btn_Atualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(1035, 28);
            this.btn_Atualizar.TabIndex = 0;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(16, 164);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(1035, 28);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Location = new System.Drawing.Point(16, 511);
            this.btn_Deletar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(1035, 28);
            this.btn_Deletar.TabIndex = 2;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(16, 95);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(132, 22);
            this.txt_Nome.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(453, 95);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(132, 22);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(792, 95);
            this.txt_Idade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(132, 22);
            this.txt_Idade.TabIndex = 5;
            // 
            // dgv_Mostrar
            // 
            this.dgv_Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mostrar.Location = new System.Drawing.Point(1, 286);
            this.dgv_Mostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Mostrar.Name = "dgv_Mostrar";
            this.dgv_Mostrar.RowHeadersWidth = 51;
            this.dgv_Mostrar.Size = new System.Drawing.Size(1049, 185);
            this.dgv_Mostrar.TabIndex = 6;
            this.dgv_Mostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mostrar_CellContentClick);
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(43, 31);
            this.lb_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(44, 16);
            this.lb_Nome.TabIndex = 7;
            this.lb_Nome.Text = "Nome";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(487, 31);
            this.lb_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(45, 16);
            this.lb_Email.TabIndex = 8;
            this.lb_Email.Text = "E-mail";
            // 
            // lb_Idade
            // 
            this.lb_Idade.AutoSize = true;
            this.lb_Idade.Location = new System.Drawing.Point(837, 31);
            this.lb_Idade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Idade.Name = "lb_Idade";
            this.lb_Idade.Size = new System.Drawing.Size(42, 16);
            this.lb_Idade.TabIndex = 9;
            this.lb_Idade.Text = "Idade";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(16, 547);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(1035, 28);
            this.btn_Voltar.TabIndex = 10;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 593);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.lb_Idade);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_Nome);
            this.Controls.Add(this.dgv_Mostrar);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Atualizar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.DataGridView dgv_Mostrar;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_Idade;
        private System.Windows.Forms.Button btn_Voltar;
    }
}

