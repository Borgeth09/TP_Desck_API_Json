namespace Aula08_JSON.View
{
    partial class Form_Principal
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
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(92, 74);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(146, 67);
            this.btn_Clientes.TabIndex = 0;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Location = new System.Drawing.Point(92, 161);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(146, 74);
            this.btn_Usuarios.TabIndex = 1;
            this.btn_Usuarios.Text = "Usuários";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 308);
            this.Controls.Add(this.btn_Usuarios);
            this.Controls.Add(this.btn_Clientes);
            this.Name = "Form_Principal";
            this.Text = "Form_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Usuarios;
    }
}