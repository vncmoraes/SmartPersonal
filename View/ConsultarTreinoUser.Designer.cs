namespace SmartPersonal.View
{
    partial class frmConsultarTreinoUser
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
            this.id_treino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_instrutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_aparelho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.series_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeticoes_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracao_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
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
            this.id_treino,
            this.id_user,
            this.nome_instrutor,
            this.nome_exercicio,
            this.nome_aparelho,
            this.tipo_exercicio,
            this.series_exercicio,
            this.repeticoes_exercicio,
            this.duracao_exercicio});
            this.dg1.Location = new System.Drawing.Point(25, 25);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(563, 210);
            this.dg1.TabIndex = 8;
            // 
            // id_treino
            // 
            this.id_treino.HeaderText = "id_treino";
            this.id_treino.MinimumWidth = 20;
            this.id_treino.Name = "id_treino";
            this.id_treino.ReadOnly = true;
            this.id_treino.Visible = false;
            this.id_treino.Width = 50;
            // 
            // id_user
            // 
            this.id_user.HeaderText = "id_user";
            this.id_user.MinimumWidth = 20;
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            this.id_user.Visible = false;
            this.id_user.Width = 50;
            // 
            // nome_instrutor
            // 
            this.nome_instrutor.HeaderText = "Instrutor";
            this.nome_instrutor.MinimumWidth = 50;
            this.nome_instrutor.Name = "nome_instrutor";
            this.nome_instrutor.ReadOnly = true;
            this.nome_instrutor.Width = 80;
            // 
            // nome_exercicio
            // 
            this.nome_exercicio.HeaderText = "Exercicio";
            this.nome_exercicio.MinimumWidth = 50;
            this.nome_exercicio.Name = "nome_exercicio";
            this.nome_exercicio.ReadOnly = true;
            this.nome_exercicio.Width = 80;
            // 
            // nome_aparelho
            // 
            this.nome_aparelho.HeaderText = "Aparelho";
            this.nome_aparelho.MinimumWidth = 50;
            this.nome_aparelho.Name = "nome_aparelho";
            this.nome_aparelho.ReadOnly = true;
            this.nome_aparelho.Width = 80;
            // 
            // tipo_exercicio
            // 
            this.tipo_exercicio.HeaderText = "Tipo Exercício";
            this.tipo_exercicio.Name = "tipo_exercicio";
            this.tipo_exercicio.ReadOnly = true;
            // 
            // series_exercicio
            // 
            this.series_exercicio.HeaderText = "Series";
            this.series_exercicio.MinimumWidth = 20;
            this.series_exercicio.Name = "series_exercicio";
            this.series_exercicio.ReadOnly = true;
            this.series_exercicio.Width = 50;
            // 
            // repeticoes_exercicio
            // 
            this.repeticoes_exercicio.HeaderText = "Repeticoes";
            this.repeticoes_exercicio.MinimumWidth = 40;
            this.repeticoes_exercicio.Name = "repeticoes_exercicio";
            this.repeticoes_exercicio.ReadOnly = true;
            this.repeticoes_exercicio.Width = 70;
            // 
            // duracao_exercicio
            // 
            this.duracao_exercicio.HeaderText = "Duração";
            this.duracao_exercicio.Name = "duracao_exercicio";
            this.duracao_exercicio.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(357, 261);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 27);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 11F);
            this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluir.Location = new System.Drawing.Point(268, 262);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 26);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(179, 261);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(83, 27);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmConsultarTreinoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 310);
            this.ControlBox = false;
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarTreinoUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Exercícios do(a) ";
            this.Load += new System.EventHandler(this.frmConsultarTreinoUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_treino;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_instrutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_aparelho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn series_exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeticoes_exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracao_exercicio;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
    }
}