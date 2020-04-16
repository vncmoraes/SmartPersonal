namespace SmartPersonal.View
{
    partial class frmCadastroExercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroExercicio));
            this.lblAparelho = new System.Windows.Forms.Label();
            this.lblNomeEx = new System.Windows.Forms.Label();
            this.txtNomeEx = new System.Windows.Forms.TextBox();
            this.cbAparelho = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoEx = new System.Windows.Forms.Label();
            this.cbTipoEx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAparelho
            // 
            this.lblAparelho.AutoSize = true;
            this.lblAparelho.Font = new System.Drawing.Font("Arial", 11F);
            this.lblAparelho.Location = new System.Drawing.Point(24, 84);
            this.lblAparelho.Name = "lblAparelho";
            this.lblAparelho.Size = new System.Drawing.Size(69, 17);
            this.lblAparelho.TabIndex = 0;
            this.lblAparelho.Text = "Aparelho:";
            // 
            // lblNomeEx
            // 
            this.lblNomeEx.AutoSize = true;
            this.lblNomeEx.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeEx.Location = new System.Drawing.Point(24, 20);
            this.lblNomeEx.Name = "lblNomeEx";
            this.lblNomeEx.Size = new System.Drawing.Size(51, 17);
            this.lblNomeEx.TabIndex = 1;
            this.lblNomeEx.Text = "Nome:";
            // 
            // txtNomeEx
            // 
            this.txtNomeEx.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNomeEx.Location = new System.Drawing.Point(27, 40);
            this.txtNomeEx.Name = "txtNomeEx";
            this.txtNomeEx.Size = new System.Drawing.Size(211, 24);
            this.txtNomeEx.TabIndex = 2;
            this.txtNomeEx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeEx_KeyPress);
            // 
            // cbAparelho
            // 
            this.cbAparelho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAparelho.Font = new System.Drawing.Font("Arial", 11F);
            this.cbAparelho.FormattingEnabled = true;
            this.cbAparelho.Location = new System.Drawing.Point(27, 104);
            this.cbAparelho.Name = "cbAparelho";
            this.cbAparelho.Size = new System.Drawing.Size(144, 25);
            this.cbAparelho.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCadastrar.Location = new System.Drawing.Point(27, 225);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(81, 27);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(114, 225);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(71, 27);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(191, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 27);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoEx
            // 
            this.lblTipoEx.AutoSize = true;
            this.lblTipoEx.Font = new System.Drawing.Font("Arial", 11F);
            this.lblTipoEx.Location = new System.Drawing.Point(24, 151);
            this.lblTipoEx.Name = "lblTipoEx";
            this.lblTipoEx.Size = new System.Drawing.Size(123, 17);
            this.lblTipoEx.TabIndex = 13;
            this.lblTipoEx.Text = "Tipo do Exercicio:";
            // 
            // cbTipoEx
            // 
            this.cbTipoEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEx.Font = new System.Drawing.Font("Arial", 11F);
            this.cbTipoEx.FormattingEnabled = true;
            this.cbTipoEx.Items.AddRange(new object[] {
            "Aerobico",
            "Anaerobico"});
            this.cbTipoEx.Location = new System.Drawing.Point(27, 171);
            this.cbTipoEx.Name = "cbTipoEx";
            this.cbTipoEx.Size = new System.Drawing.Size(144, 25);
            this.cbTipoEx.TabIndex = 14;
            // 
            // frmCadastroExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 274);
            this.ControlBox = false;
            this.Controls.Add(this.cbTipoEx);
            this.Controls.Add(this.lblTipoEx);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbAparelho);
            this.Controls.Add(this.txtNomeEx);
            this.Controls.Add(this.lblNomeEx);
            this.Controls.Add(this.lblAparelho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroExercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Exercício";
            this.Load += new System.EventHandler(this.frmCadastroExercicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAparelho;
        private System.Windows.Forms.Label lblNomeEx;
        private System.Windows.Forms.TextBox txtNomeEx;
        private System.Windows.Forms.ComboBox cbAparelho;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoEx;
        private System.Windows.Forms.ComboBox cbTipoEx;
    }
}