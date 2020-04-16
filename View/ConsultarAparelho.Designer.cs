namespace SmartPersonal.View
{
    partial class frmConsultarAparelho
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
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.id_aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto_aparelho = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AllowUserToResizeRows = false;
            this.dg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_aparelho,
            this.nome_aparelho,
            this.foto_aparelho});
            this.dg1.Location = new System.Drawing.Point(27, 23);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(356, 221);
            this.dg1.TabIndex = 1;
            // 
            // id_aparelho
            // 
            this.id_aparelho.HeaderText = "ID";
            this.id_aparelho.MinimumWidth = 25;
            this.id_aparelho.Name = "id_aparelho";
            this.id_aparelho.ReadOnly = true;
            this.id_aparelho.Visible = false;
            this.id_aparelho.Width = 25;
            // 
            // nome_aparelho
            // 
            this.nome_aparelho.HeaderText = "Nome do Aparelho";
            this.nome_aparelho.MinimumWidth = 120;
            this.nome_aparelho.Name = "nome_aparelho";
            this.nome_aparelho.ReadOnly = true;
            this.nome_aparelho.Width = 194;
            // 
            // foto_aparelho
            // 
            this.foto_aparelho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.foto_aparelho.HeaderText = "Foto";
            this.foto_aparelho.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto_aparelho.MinimumWidth = 130;
            this.foto_aparelho.Name = "foto_aparelho";
            this.foto_aparelho.ReadOnly = true;
            this.foto_aparelho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foto_aparelho.Width = 130;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 11F);
            this.btnExcluir.Location = new System.Drawing.Point(165, 268);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 27);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSair.Location = new System.Drawing.Point(259, 268);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(73, 27);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAlterar.Location = new System.Drawing.Point(70, 268);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 27);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmConsultarAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 316);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarAparelho";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aparelhos Cadastrados";
            this.Load += new System.EventHandler(this.ConsultarAparelho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_aparelho;
        private System.Windows.Forms.DataGridViewImageColumn foto_aparelho;
    }
}