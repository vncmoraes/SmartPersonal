namespace SmartPersonal
{
    partial class frmConsultarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarUsuario));
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanasc_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds1 = new System.Data.DataSet();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.rdbtnNome = new System.Windows.Forms.RadioButton();
            this.rdbtnEmail = new System.Windows.Forms.RadioButton();
            this.gpboxProcurar = new System.Windows.Forms.GroupBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            this.gpboxProcurar.SuspendLayout();
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
            this.id_usuario,
            this.nome_usuario,
            this.datanasc_usuario,
            this.peso_usuario,
            this.altura_usuario,
            this.sexo_usuario,
            this.email_usuario,
            this.login_usuario});
            resources.ApplyResources(this.dg1, "dg1");
            this.dg1.MultiSelect = false;
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // id_usuario
            // 
            resources.ApplyResources(this.id_usuario, "id_usuario");
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // nome_usuario
            // 
            resources.ApplyResources(this.nome_usuario, "nome_usuario");
            this.nome_usuario.Name = "nome_usuario";
            this.nome_usuario.ReadOnly = true;
            // 
            // datanasc_usuario
            // 
            resources.ApplyResources(this.datanasc_usuario, "datanasc_usuario");
            this.datanasc_usuario.Name = "datanasc_usuario";
            this.datanasc_usuario.ReadOnly = true;
            // 
            // peso_usuario
            // 
            resources.ApplyResources(this.peso_usuario, "peso_usuario");
            this.peso_usuario.Name = "peso_usuario";
            this.peso_usuario.ReadOnly = true;
            // 
            // altura_usuario
            // 
            resources.ApplyResources(this.altura_usuario, "altura_usuario");
            this.altura_usuario.Name = "altura_usuario";
            this.altura_usuario.ReadOnly = true;
            // 
            // sexo_usuario
            // 
            resources.ApplyResources(this.sexo_usuario, "sexo_usuario");
            this.sexo_usuario.Name = "sexo_usuario";
            this.sexo_usuario.ReadOnly = true;
            // 
            // email_usuario
            // 
            resources.ApplyResources(this.email_usuario, "email_usuario");
            this.email_usuario.Name = "email_usuario";
            this.email_usuario.ReadOnly = true;
            // 
            // login_usuario
            // 
            resources.ApplyResources(this.login_usuario, "login_usuario");
            this.login_usuario.Name = "login_usuario";
            this.login_usuario.ReadOnly = true;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "ds1";
            // 
            // txtKeyWord
            // 
            resources.ApplyResources(this.txtKeyWord, "txtKeyWord");
            this.txtKeyWord.Name = "txtKeyWord";
            // 
            // rdbtnNome
            // 
            resources.ApplyResources(this.rdbtnNome, "rdbtnNome");
            this.rdbtnNome.Checked = true;
            this.rdbtnNome.Name = "rdbtnNome";
            this.rdbtnNome.TabStop = true;
            this.rdbtnNome.UseVisualStyleBackColor = true;
            // 
            // rdbtnEmail
            // 
            resources.ApplyResources(this.rdbtnEmail, "rdbtnEmail");
            this.rdbtnEmail.Name = "rdbtnEmail";
            this.rdbtnEmail.UseVisualStyleBackColor = true;
            // 
            // gpboxProcurar
            // 
            this.gpboxProcurar.BackColor = System.Drawing.SystemColors.Control;
            this.gpboxProcurar.Controls.Add(this.btnProcurar);
            this.gpboxProcurar.Controls.Add(this.rdbtnNome);
            this.gpboxProcurar.Controls.Add(this.txtKeyWord);
            this.gpboxProcurar.Controls.Add(this.rdbtnEmail);
            resources.ApplyResources(this.gpboxProcurar, "gpboxProcurar");
            this.gpboxProcurar.Name = "gpboxProcurar";
            this.gpboxProcurar.TabStop = false;
            // 
            // btnProcurar
            // 
            resources.ApplyResources(this.btnProcurar, "btnProcurar");
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // btnLimpar
            // 
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            resources.ApplyResources(this.btnAlterar, "btnAlterar");
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmConsultarUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.gpboxProcurar);
            this.Controls.Add(this.dg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarUsuario";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmConsultarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            this.gpboxProcurar.ResumeLayout(false);
            this.gpboxProcurar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dg1;
        private System.Data.DataSet ds1;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.RadioButton rdbtnNome;
        private System.Windows.Forms.RadioButton rdbtnEmail;
        private System.Windows.Forms.GroupBox gpboxProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanasc_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_usuario;
    }
}