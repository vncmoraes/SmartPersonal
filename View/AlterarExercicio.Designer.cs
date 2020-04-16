namespace SmartPersonal.View
{
    partial class frmAlterarExercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarExercicio));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNomeEx = new System.Windows.Forms.TextBox();
            this.lblNomeEx = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblAparelho = new System.Windows.Forms.Label();
            this.cbAparelho = new System.Windows.Forms.ComboBox();
            this.cbTipoEx = new System.Windows.Forms.ComboBox();
            this.lblTipoEx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(199, 281);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 27);
            this.btnCancelar.TabIndex = 79;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(109, 281);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 27);
            this.btnLimpar.TabIndex = 78;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAlterar.Location = new System.Drawing.Point(25, 281);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(76, 27);
            this.btnAlterar.TabIndex = 77;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtNomeEx
            // 
            this.txtNomeEx.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNomeEx.Location = new System.Drawing.Point(25, 78);
            this.txtNomeEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeEx.Name = "txtNomeEx";
            this.txtNomeEx.Size = new System.Drawing.Size(255, 24);
            this.txtNomeEx.TabIndex = 76;
            this.txtNomeEx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeEx_KeyPress);
            // 
            // lblNomeEx
            // 
            this.lblNomeEx.AutoSize = true;
            this.lblNomeEx.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeEx.Location = new System.Drawing.Point(22, 56);
            this.lblNomeEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEx.Name = "lblNomeEx";
            this.lblNomeEx.Size = new System.Drawing.Size(135, 17);
            this.lblNomeEx.TabIndex = 81;
            this.lblNomeEx.Text = "Nome do Exercício:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCodigo.Location = new System.Drawing.Point(172, 15);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(52, 24);
            this.txtCodigo.TabIndex = 75;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCodigo.Location = new System.Drawing.Point(22, 18);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(142, 17);
            this.lblCodigo.TabIndex = 80;
            this.lblCodigo.Text = "Código do Exercício:";
            // 
            // lblAparelho
            // 
            this.lblAparelho.AutoSize = true;
            this.lblAparelho.Font = new System.Drawing.Font("Arial", 11F);
            this.lblAparelho.Location = new System.Drawing.Point(22, 124);
            this.lblAparelho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAparelho.Name = "lblAparelho";
            this.lblAparelho.Size = new System.Drawing.Size(69, 17);
            this.lblAparelho.TabIndex = 83;
            this.lblAparelho.Text = "Aparelho:";
            // 
            // cbAparelho
            // 
            this.cbAparelho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAparelho.Font = new System.Drawing.Font("Arial", 11F);
            this.cbAparelho.FormattingEnabled = true;
            this.cbAparelho.Location = new System.Drawing.Point(25, 144);
            this.cbAparelho.Name = "cbAparelho";
            this.cbAparelho.Size = new System.Drawing.Size(144, 25);
            this.cbAparelho.TabIndex = 84;
            // 
            // cbTipoEx
            // 
            this.cbTipoEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEx.Font = new System.Drawing.Font("Arial", 11F);
            this.cbTipoEx.FormattingEnabled = true;
            this.cbTipoEx.Items.AddRange(new object[] {
            "Aerobico",
            "Anaerobico"});
            this.cbTipoEx.Location = new System.Drawing.Point(25, 213);
            this.cbTipoEx.Name = "cbTipoEx";
            this.cbTipoEx.Size = new System.Drawing.Size(144, 25);
            this.cbTipoEx.TabIndex = 86;
            // 
            // lblTipoEx
            // 
            this.lblTipoEx.AutoSize = true;
            this.lblTipoEx.Font = new System.Drawing.Font("Arial", 11F);
            this.lblTipoEx.Location = new System.Drawing.Point(22, 193);
            this.lblTipoEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoEx.Name = "lblTipoEx";
            this.lblTipoEx.Size = new System.Drawing.Size(123, 17);
            this.lblTipoEx.TabIndex = 85;
            this.lblTipoEx.Text = "Tipo de Exercício:";
            // 
            // frmAlterarExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 333);
            this.ControlBox = false;
            this.Controls.Add(this.cbTipoEx);
            this.Controls.Add(this.lblTipoEx);
            this.Controls.Add(this.cbAparelho);
            this.Controls.Add(this.lblAparelho);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtNomeEx);
            this.Controls.Add(this.lblNomeEx);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarExercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Exercício";
            this.Load += new System.EventHandler(this.frmAlterarExercicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.TextBox txtNomeEx;
        private System.Windows.Forms.Label lblNomeEx;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblAparelho;
        public System.Windows.Forms.ComboBox cbAparelho;
        public System.Windows.Forms.ComboBox cbTipoEx;
        private System.Windows.Forms.Label lblTipoEx;
    }
}