namespace Aula08_JSON.View
{
    partial class Forms_Json
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
            this.dgv_Mostrar = new System.Windows.Forms.DataGridView();
            this.btn_Obter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Mostrar
            // 
            this.dgv_Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mostrar.Location = new System.Drawing.Point(85, 24);
            this.dgv_Mostrar.Name = "dgv_Mostrar";
            this.dgv_Mostrar.RowHeadersWidth = 51;
            this.dgv_Mostrar.RowTemplate.Height = 24;
            this.dgv_Mostrar.Size = new System.Drawing.Size(606, 345);
            this.dgv_Mostrar.TabIndex = 0;
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(283, 391);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(199, 47);
            this.btn_Obter.TabIndex = 1;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.btn_Obter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(9, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(283, 458);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(199, 47);
            this.btn_Voltar.TabIndex = 3;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // Forms_Json
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.dgv_Mostrar);
            this.Name = "Forms_Json";
            this.Text = "Forms_Json";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Mostrar;
        private System.Windows.Forms.Button btn_Obter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Voltar;
    }
}