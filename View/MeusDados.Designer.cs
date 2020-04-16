namespace SmartPersonal.View
{
    partial class frmMeusDados
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblSenhaConf = new System.Windows.Forms.Label();
            this.lblForcaSenha = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(241, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 27);
            this.btnCancelar.TabIndex = 121;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(155, 323);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 27);
            this.btnLimpar.TabIndex = 120;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAlterar.Location = new System.Drawing.Point(69, 323);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 27);
            this.btnAlterar.TabIndex = 119;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 11F);
            this.lblLogin.Location = new System.Drawing.Point(34, 122);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 118;
            this.lblLogin.Text = "Login:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeCompleto.Location = new System.Drawing.Point(34, 66);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(118, 17);
            this.lblNomeCompleto.TabIndex = 117;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial", 11F);
            this.txtLogin.Location = new System.Drawing.Point(37, 142);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(260, 24);
            this.txtLogin.TabIndex = 116;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNome.Location = new System.Drawing.Point(37, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 24);
            this.txtNome.TabIndex = 115;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.lblSenha.Location = new System.Drawing.Point(34, 183);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(54, 17);
            this.lblSenha.TabIndex = 123;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.txtSenha.Location = new System.Drawing.Point(37, 203);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(171, 24);
            this.txtSenha.TabIndex = 122;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.lblConfirmaSenha.Location = new System.Drawing.Point(34, 241);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(123, 17);
            this.lblConfirmaSenha.TabIndex = 125;
            this.lblConfirmaSenha.Text = "Confirmar Senha:";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.txtConfirmaSenha.Location = new System.Drawing.Point(37, 261);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(171, 24);
            this.txtConfirmaSenha.TabIndex = 124;
            this.txtConfirmaSenha.TextChanged += new System.EventHandler(this.txtConfirmaSenha_TextChanged);
            // 
            // lblSenhaConf
            // 
            this.lblSenhaConf.AutoSize = true;
            this.lblSenhaConf.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaConf.Location = new System.Drawing.Point(214, 264);
            this.lblSenhaConf.Name = "lblSenhaConf";
            this.lblSenhaConf.Size = new System.Drawing.Size(0, 18);
            this.lblSenhaConf.TabIndex = 127;
            // 
            // lblForcaSenha
            // 
            this.lblForcaSenha.AutoSize = true;
            this.lblForcaSenha.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForcaSenha.Location = new System.Drawing.Point(214, 206);
            this.lblForcaSenha.Name = "lblForcaSenha";
            this.lblForcaSenha.Size = new System.Drawing.Size(0, 18);
            this.lblForcaSenha.TabIndex = 126;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCodigo.Location = new System.Drawing.Point(35, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(132, 17);
            this.lblCodigo.TabIndex = 129;
            this.lblCodigo.Text = "Código do Usuário:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCodigo.Location = new System.Drawing.Point(173, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(40, 24);
            this.txtCodigo.TabIndex = 128;
            // 
            // frmMeusDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 369);
            this.ControlBox = false;
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblSenhaConf);
            this.Controls.Add(this.lblForcaSenha);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMeusDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meus Dados";
            this.Load += new System.EventHandler(this.frmMeusDados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNomeCompleto;
        public System.Windows.Forms.TextBox txtLogin;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        public System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblSenhaConf;
        private System.Windows.Forms.Label lblForcaSenha;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtCodigo;
    }
}