namespace SmartPersonal.View
{
    partial class frmConsultarExercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarExercicio));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.id_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 11F);
            this.btnExcluir.Location = new System.Drawing.Point(248, 194);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 27);
            this.btnExcluir.TabIndex = 84;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSair.Location = new System.Drawing.Point(342, 194);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 27);
            this.btnSair.TabIndex = 85;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAlterar.Location = new System.Drawing.Point(153, 194);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 27);
            this.btnAlterar.TabIndex = 83;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AllowUserToResizeRows = false;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_exercicio,
            this.nome_exercicio,
            this.nome_aparelho,
            this.tipo_exercicio});
            this.dg1.Location = new System.Drawing.Point(21, 23);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(544, 150);
            this.dg1.TabIndex = 82;
            // 
            // id_exercicio
            // 
            this.id_exercicio.HeaderText = "ID";
            this.id_exercicio.MinimumWidth = 25;
            this.id_exercicio.Name = "id_exercicio";
            this.id_exercicio.ReadOnly = true;
            this.id_exercicio.Visible = false;
            this.id_exercicio.Width = 25;
            // 
            // nome_exercicio
            // 
            this.nome_exercicio.HeaderText = "Nome do Exercício";
            this.nome_exercicio.MinimumWidth = 120;
            this.nome_exercicio.Name = "nome_exercicio";
            this.nome_exercicio.ReadOnly = true;
            this.nome_exercicio.Width = 190;
            // 
            // nome_aparelho
            // 
            this.nome_aparelho.HeaderText = "Nome do Aparelho";
            this.nome_aparelho.MinimumWidth = 120;
            this.nome_aparelho.Name = "nome_aparelho";
            this.nome_aparelho.ReadOnly = true;
            this.nome_aparelho.Width = 190;
            // 
            // tipo_exercicio
            // 
            this.tipo_exercicio.HeaderText = "Tipo do Exercicio";
            this.tipo_exercicio.MinimumWidth = 100;
            this.tipo_exercicio.Name = "tipo_exercicio";
            this.tipo_exercicio.ReadOnly = true;
            this.tipo_exercicio.Width = 160;
            // 
            // frmConsultarExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 235);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarExercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercícios Cadastrados";
            this.Load += new System.EventHandler(this.frmConsultarExercicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_exercicio;
    }
}