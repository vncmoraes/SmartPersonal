namespace SmartPersonal.View
{
    partial class frmConsultarTreino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarTreino));
            this.btnProcurar = new System.Windows.Forms.Button();
            this.gpboxProcurar = new System.Windows.Forms.GroupBox();
            this.rdbtnNome = new System.Windows.Forms.RadioButton();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.rdbtnEmail = new System.Windows.Forms.RadioButton();
            this.ds1 = new System.Data.DataSet();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnNovoExercicio = new System.Windows.Forms.Button();
            this.btnTreino = new System.Windows.Forms.Button();
            this.lblSelecioneUsuario = new System.Windows.Forms.Label();
            this.gpboxProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(528, 32);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(77, 28);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // gpboxProcurar
            // 
            this.gpboxProcurar.BackColor = System.Drawing.SystemColors.Control;
            this.gpboxProcurar.Controls.Add(this.btnProcurar);
            this.gpboxProcurar.Controls.Add(this.rdbtnNome);
            this.gpboxProcurar.Controls.Add(this.txtKeyWord);
            this.gpboxProcurar.Controls.Add(this.rdbtnEmail);
            this.gpboxProcurar.Font = new System.Drawing.Font("Arial", 11F);
            this.gpboxProcurar.Location = new System.Drawing.Point(25, 24);
            this.gpboxProcurar.Name = "gpboxProcurar";
            this.gpboxProcurar.Size = new System.Drawing.Size(626, 76);
            this.gpboxProcurar.TabIndex = 59;
            this.gpboxProcurar.TabStop = false;
            this.gpboxProcurar.Text = "Procurar cliente por";
            // 
            // rdbtnNome
            // 
            this.rdbtnNome.AutoSize = true;
            this.rdbtnNome.Checked = true;
            this.rdbtnNome.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtKeyWord.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyWord.Location = new System.Drawing.Point(228, 35);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(278, 23);
            this.txtKeyWord.TabIndex = 1;
            // 
            // rdbtnEmail
            // 
            this.rdbtnEmail.AutoSize = true;
            this.rdbtnEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEmail.Location = new System.Drawing.Point(134, 36);
            this.rdbtnEmail.Name = "rdbtnEmail";
            this.rdbtnEmail.Size = new System.Drawing.Size(60, 20);
            this.rdbtnEmail.TabIndex = 9;
            this.rdbtnEmail.Text = "Email";
            this.rdbtnEmail.UseVisualStyleBackColor = true;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "ds1";
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
            this.email_usuario,
            this.login_usuario});
            this.dg1.Location = new System.Drawing.Point(112, 152);
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg1.Size = new System.Drawing.Size(454, 210);
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
            this.nome_usuario.MinimumWidth = 100;
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.ReadOnly = true;
            this.nome_usuario.Width = 120;
            // 
            // email_usuario
            // 
            this.email_usuario.HeaderText = "Email";
            this.email_usuario.MinimumWidth = 170;
            this.email_usuario.Name = "email_usuario";
            this.email_usuario.ReadOnly = true;
            this.email_usuario.Width = 230;
            // 
            // login_usuario
            // 
            this.login_usuario.HeaderText = "Login";
            this.login_usuario.MinimumWidth = 50;
            this.login_usuario.Name = "login_usuario";
            this.login_usuario.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 11F);
            this.btnSair.Location = new System.Drawing.Point(487, 386);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 27);
            this.btnSair.TabIndex = 64;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(411, 386);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 27);
            this.btnLimpar.TabIndex = 63;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnNovoExercicio
            // 
            this.btnNovoExercicio.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoExercicio.Location = new System.Drawing.Point(124, 386);
            this.btnNovoExercicio.Name = "btnNovoExercicio";
            this.btnNovoExercicio.Size = new System.Drawing.Size(116, 27);
            this.btnNovoExercicio.TabIndex = 65;
            this.btnNovoExercicio.Text = "Novo Exercício";
            this.btnNovoExercicio.UseVisualStyleBackColor = true;
            this.btnNovoExercicio.Click += new System.EventHandler(this.btnExercicios_Click);
            // 
            // btnTreino
            // 
            this.btnTreino.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreino.Location = new System.Drawing.Point(246, 386);
            this.btnTreino.Name = "btnTreino";
            this.btnTreino.Size = new System.Drawing.Size(159, 27);
            this.btnTreino.TabIndex = 66;
            this.btnTreino.Text = "Tabela de Exercicios";
            this.btnTreino.UseVisualStyleBackColor = true;
            this.btnTreino.Click += new System.EventHandler(this.btnTreino_Click);
            // 
            // lblSelecioneUsuario
            // 
            this.lblSelecioneUsuario.AutoSize = true;
            this.lblSelecioneUsuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneUsuario.Location = new System.Drawing.Point(227, 118);
            this.lblSelecioneUsuario.Name = "lblSelecioneUsuario";
            this.lblSelecioneUsuario.Size = new System.Drawing.Size(210, 18);
            this.lblSelecioneUsuario.TabIndex = 67;
            this.lblSelecioneUsuario.Text = "Selecione um cliente abaixo:";
            // 
            // frmConsultarTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 439);
            this.ControlBox = false;
            this.Controls.Add(this.lblSelecioneUsuario);
            this.Controls.Add(this.btnTreino);
            this.Controls.Add(this.btnNovoExercicio);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gpboxProcurar);
            this.Controls.Add(this.dg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarTreino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Treino";
            this.Load += new System.EventHandler(this.frmConsultarTreino_Load);
            this.gpboxProcurar.ResumeLayout(false);
            this.gpboxProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.GroupBox gpboxProcurar;
        private System.Windows.Forms.RadioButton rdbtnNome;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.RadioButton rdbtnEmail;
        private System.Data.DataSet ds1;
        public System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnNovoExercicio;
        private System.Windows.Forms.Button btnTreino;
        private System.Windows.Forms.Label lblSelecioneUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_usuario;
    }
}