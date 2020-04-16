namespace SmartPersonal.View
{
    partial class frmConsultarInstrutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarInstrutor));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gpboxProcurar = new System.Windows.Forms.GroupBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.rdbtnNome = new System.Windows.Forms.RadioButton();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.rdbtnLogin = new System.Windows.Forms.RadioButton();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpboxProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 11F);
            this.btnExcluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluir.Location = new System.Drawing.Point(281, 357);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 27);
            this.btnExcluir.TabIndex = 55;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(460, 357);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 27);
            this.btnSair.TabIndex = 57;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(367, 357);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 27);
            this.btnLimpar.TabIndex = 56;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(191, 357);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 27);
            this.btnAlterar.TabIndex = 54;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gpboxProcurar
            // 
            this.gpboxProcurar.BackColor = System.Drawing.SystemColors.Control;
            this.gpboxProcurar.Controls.Add(this.btnProcurar);
            this.gpboxProcurar.Controls.Add(this.rdbtnNome);
            this.gpboxProcurar.Controls.Add(this.txtKeyWord);
            this.gpboxProcurar.Controls.Add(this.rdbtnLogin);
            this.gpboxProcurar.Font = new System.Drawing.Font("Arial", 11F);
            this.gpboxProcurar.Location = new System.Drawing.Point(22, 23);
            this.gpboxProcurar.Name = "gpboxProcurar";
            this.gpboxProcurar.Size = new System.Drawing.Size(692, 76);
            this.gpboxProcurar.TabIndex = 59;
            this.gpboxProcurar.TabStop = false;
            this.gpboxProcurar.Text = "Procurar instrutor por";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnProcurar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProcurar.Location = new System.Drawing.Point(596, 32);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(77, 28);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // rdbtnNome
            // 
            this.rdbtnNome.AutoSize = true;
            this.rdbtnNome.Checked = true;
            this.rdbtnNome.Font = new System.Drawing.Font("Arial", 10F);
            this.rdbtnNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbtnNome.Location = new System.Drawing.Point(25, 36);
            this.rdbtnNome.Name = "rdbtnNome";
            this.rdbtnNome.Size = new System.Drawing.Size(62, 20);
            this.rdbtnNome.TabIndex = 8;
            this.rdbtnNome.TabStop = true;
            this.rdbtnNome.Text = "Nome";
            this.rdbtnNome.UseVisualStyleBackColor = true;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Font = new System.Drawing.Font("Arial", 10F);
            this.txtKeyWord.Location = new System.Drawing.Point(228, 35);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(343, 23);
            this.txtKeyWord.TabIndex = 1;
            // 
            // rdbtnLogin
            // 
            this.rdbtnLogin.AutoSize = true;
            this.rdbtnLogin.Font = new System.Drawing.Font("Arial", 10F);
            this.rdbtnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbtnLogin.Location = new System.Drawing.Point(134, 36);
            this.rdbtnLogin.Name = "rdbtnLogin";
            this.rdbtnLogin.Size = new System.Drawing.Size(61, 20);
            this.rdbtnLogin.TabIndex = 9;
            this.rdbtnLogin.Text = "Login";
            this.rdbtnLogin.UseVisualStyleBackColor = true;
            // 
            // dg1
            // 
            this.dg1.AllowUserToAddRows = false;
            this.dg1.AllowUserToDeleteRows = false;
            this.dg1.AllowUserToResizeRows = false;
            this.dg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nome_usuario,
            this.login_usuario});
            this.dg1.Location = new System.Drawing.Point(214, 120);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(304, 210);
            this.dg1.TabIndex = 58;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID";
            this.id_usuario.MinimumWidth = 25;
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            this.id_usuario.Width = 25;
            // 
            // nome_usuario
            // 
            this.nome_usuario.HeaderText = "Nome";
            this.nome_usuario.MinimumWidth = 150;
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.ReadOnly = true;
            this.nome_usuario.Width = 150;
            // 
            // login_usuario
            // 
            this.login_usuario.HeaderText = "Login";
            this.login_usuario.MinimumWidth = 150;
            this.login_usuario.Name = "login_usuario";
            this.login_usuario.ReadOnly = true;
            this.login_usuario.Width = 150;
            // 
            // frmConsultarInstrutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 414);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gpboxProcurar);
            this.Controls.Add(this.dg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarInstrutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Instrutor";
            this.Load += new System.EventHandler(this.frmConsultarInstrutor_Load);
            this.gpboxProcurar.ResumeLayout(false);
            this.gpboxProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gpboxProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.RadioButton rdbtnNome;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.RadioButton rdbtnLogin;
        public System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_usuario;
    }
}