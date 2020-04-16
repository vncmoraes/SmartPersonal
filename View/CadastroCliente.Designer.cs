namespace SmartPersonal
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblForcaSenha = new System.Windows.Forms.Label();
            this.lblSenhaConf = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNome.Location = new System.Drawing.Point(31, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(348, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPeso.Location = new System.Drawing.Point(80, 92);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(71, 24);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Arial", 11F);
            this.txtAltura.Location = new System.Drawing.Point(260, 92);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(71, 24);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial", 11F);
            this.txtLogin.Location = new System.Drawing.Point(31, 333);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(181, 24);
            this.txtLogin.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.txtSenha.Location = new System.Drawing.Point(31, 401);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(181, 24);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeCompleto.Location = new System.Drawing.Point(28, 24);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(118, 17);
            this.lblNomeCompleto.TabIndex = 12;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial", 11F);
            this.lblDataNascimento.Location = new System.Drawing.Point(28, 146);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(145, 17);
            this.lblDataNascimento.TabIndex = 13;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Arial", 11F);
            this.lblPeso.Location = new System.Drawing.Point(28, 95);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(46, 17);
            this.lblPeso.TabIndex = 14;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Arial", 11F);
            this.lblAltura.Location = new System.Drawing.Point(205, 95);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 17);
            this.lblAltura.TabIndex = 15;
            this.lblAltura.Text = "Altura:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11F);
            this.lblEmail.Location = new System.Drawing.Point(28, 247);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 17);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 11F);
            this.lblLogin.Location = new System.Drawing.Point(28, 313);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.lblSenha.Location = new System.Drawing.Point(28, 381);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(105, 17);
            this.lblSenha.TabIndex = 19;
            this.lblSenha.Text = "Digite a senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCadastrar.Location = new System.Drawing.Point(60, 522);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 26);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Arial", 11F);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(80, 191);
            this.cbSexo.MaxDropDownItems = 2;
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(122, 25);
            this.cbSexo.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Arial", 11F);
            this.lblSexo.Location = new System.Drawing.Point(28, 194);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 17);
            this.lblSexo.TabIndex = 25;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 11F);
            this.txtEmail.Location = new System.Drawing.Point(31, 267);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(348, 24);
            this.txtEmail.TabIndex = 6;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Font = new System.Drawing.Font("Arial", 11F);
            this.txtDataNasc.Location = new System.Drawing.Point(179, 143);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(83, 24);
            this.txtDataNasc.TabIndex = 4;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(166, 522);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 26);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.lblConfirmaSenha.Location = new System.Drawing.Point(28, 442);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(121, 17);
            this.lblConfirmaSenha.TabIndex = 27;
            this.lblConfirmaSenha.Text = "Confirmar senha:";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Arial", 11F);
            this.txtConfirmaSenha.Location = new System.Drawing.Point(31, 462);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(181, 24);
            this.txtConfirmaSenha.TabIndex = 26;
            this.txtConfirmaSenha.TextChanged += new System.EventHandler(this.txtConfirmaSenha_TextChanged);
            // 
            // lblForcaSenha
            // 
            this.lblForcaSenha.AutoSize = true;
            this.lblForcaSenha.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForcaSenha.Location = new System.Drawing.Point(218, 404);
            this.lblForcaSenha.Name = "lblForcaSenha";
            this.lblForcaSenha.Size = new System.Drawing.Size(0, 18);
            this.lblForcaSenha.TabIndex = 28;
            // 
            // lblSenhaConf
            // 
            this.lblSenhaConf.AutoSize = true;
            this.lblSenhaConf.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaConf.Location = new System.Drawing.Point(218, 465);
            this.lblSenhaConf.Name = "lblSenhaConf";
            this.lblSenhaConf.Size = new System.Drawing.Size(0, 18);
            this.lblSenhaConf.TabIndex = 29;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(260, 522);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 26);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 572);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblSenhaConf);
            this.Controls.Add(this.lblForcaSenha);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblForcaSenha;
        private System.Windows.Forms.Label lblSenhaConf;
        private System.Windows.Forms.Button btnCancelar;
    }
}

