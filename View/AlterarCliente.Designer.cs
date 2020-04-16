namespace SmartPersonal.View
{
    partial class frmAlterarCliente
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCodigo.Location = new System.Drawing.Point(25, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(127, 17);
            this.lblCodigo.TabIndex = 65;
            this.lblCodigo.Text = "Código do Cliente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCodigo.Location = new System.Drawing.Point(158, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(40, 24);
            this.txtCodigo.TabIndex = 64;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(220, 457);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 27);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(133, 457);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 27);
            this.btnLimpar.TabIndex = 83;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Font = new System.Drawing.Font("Arial", 11F);
            this.txtDataNasc.Location = new System.Drawing.Point(176, 193);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(83, 24);
            this.txtDataNasc.TabIndex = 82;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 11F);
            this.txtEmail.Location = new System.Drawing.Point(28, 322);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 24);
            this.txtEmail.TabIndex = 81;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Arial", 11F);
            this.lblSexo.Location = new System.Drawing.Point(25, 252);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 17);
            this.lblSexo.TabIndex = 80;
            this.lblSexo.Text = "Sexo:";
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
            this.cbSexo.Location = new System.Drawing.Point(76, 249);
            this.cbSexo.MaxDropDownItems = 2;
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(119, 25);
            this.cbSexo.TabIndex = 79;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAlterar.Location = new System.Drawing.Point(28, 457);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 27);
            this.btnAlterar.TabIndex = 78;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 11F);
            this.lblLogin.Location = new System.Drawing.Point(25, 372);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 76;
            this.lblLogin.Text = "Login:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11F);
            this.lblEmail.Location = new System.Drawing.Point(25, 302);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 17);
            this.lblEmail.TabIndex = 75;
            this.lblEmail.Text = "Email:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Arial", 11F);
            this.lblAltura.Location = new System.Drawing.Point(196, 140);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(49, 17);
            this.lblAltura.TabIndex = 74;
            this.lblAltura.Text = "Altura:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Arial", 11F);
            this.lblPeso.Location = new System.Drawing.Point(25, 140);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(46, 17);
            this.lblPeso.TabIndex = 73;
            this.lblPeso.Text = "Peso:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial", 11F);
            this.lblDataNascimento.Location = new System.Drawing.Point(25, 196);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(145, 17);
            this.lblDataNascimento.TabIndex = 72;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeCompleto.Location = new System.Drawing.Point(25, 68);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(118, 17);
            this.lblNomeCompleto.TabIndex = 71;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial", 11F);
            this.txtLogin.Location = new System.Drawing.Point(28, 392);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(294, 24);
            this.txtLogin.TabIndex = 69;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Arial", 11F);
            this.txtAltura.Location = new System.Drawing.Point(251, 137);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(71, 24);
            this.txtAltura.TabIndex = 68;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Arial", 11F);
            this.txtPeso.Location = new System.Drawing.Point(77, 137);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(71, 24);
            this.txtPeso.TabIndex = 67;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNome.Location = new System.Drawing.Point(28, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(294, 24);
            this.txtNome.TabIndex = 66;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 505);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.MaskedTextBox txtDataNasc;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSexo;
        public System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblNomeCompleto;
        public System.Windows.Forms.TextBox txtLogin;
        public System.Windows.Forms.TextBox txtAltura;
        public System.Windows.Forms.TextBox txtPeso;
        public System.Windows.Forms.TextBox txtNome;
    }
}