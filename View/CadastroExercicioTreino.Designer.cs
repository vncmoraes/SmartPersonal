namespace SmartPersonal.View
{
    partial class frmCadastroExercicioTreino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroExercicioTreino));
            this.lblSeries = new System.Windows.Forms.Label();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNomeExercicio = new System.Windows.Forms.Label();
            this.lblCodigoUsuario = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.lblRepeticoes = new System.Windows.Forms.Label();
            this.txtRepeticoes = new System.Windows.Forms.TextBox();
            this.lblNomeInstrutor = new System.Windows.Forms.Label();
            this.txtNomeInstrutor = new System.Windows.Forms.TextBox();
            this.lblNomeAparelho = new System.Windows.Forms.Label();
            this.txtNomeAparelho = new System.Windows.Forms.TextBox();
            this.cbExercicios = new System.Windows.Forms.ComboBox();
            this.lblTipoEx = new System.Windows.Forms.Label();
            this.txtTipoEx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Font = new System.Drawing.Font("Arial", 11F);
            this.lblSeries.Location = new System.Drawing.Point(30, 327);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(54, 17);
            this.lblSeries.TabIndex = 41;
            this.lblSeries.Text = "Séries:";
            // 
            // txtSeries
            // 
            this.txtSeries.Font = new System.Drawing.Font("Arial", 11F);
            this.txtSeries.Location = new System.Drawing.Point(33, 347);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(237, 24);
            this.txtSeries.TabIndex = 40;
            this.txtSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeries_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(201, 466);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 27);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(115, 466);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 27);
            this.btnLimpar.TabIndex = 38;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCadastrar.Location = new System.Drawing.Point(21, 466);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 27);
            this.btnCadastrar.TabIndex = 37;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNomeExercicio
            // 
            this.lblNomeExercicio.AutoSize = true;
            this.lblNomeExercicio.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeExercicio.Location = new System.Drawing.Point(30, 131);
            this.lblNomeExercicio.Name = "lblNomeExercicio";
            this.lblNomeExercicio.Size = new System.Drawing.Size(72, 17);
            this.lblNomeExercicio.TabIndex = 35;
            this.lblNomeExercicio.Text = "Exercício:";
            // 
            // lblCodigoUsuario
            // 
            this.lblCodigoUsuario.AutoSize = true;
            this.lblCodigoUsuario.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCodigoUsuario.Location = new System.Drawing.Point(27, 26);
            this.lblCodigoUsuario.Name = "lblCodigoUsuario";
            this.lblCodigoUsuario.Size = new System.Drawing.Size(127, 17);
            this.lblCodigoUsuario.TabIndex = 32;
            this.lblCodigoUsuario.Text = "Código do Cliente:";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCodigoUsuario.Location = new System.Drawing.Point(165, 23);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.ReadOnly = true;
            this.txtCodigoUsuario.Size = new System.Drawing.Size(56, 24);
            this.txtCodigoUsuario.TabIndex = 31;
            // 
            // lblRepeticoes
            // 
            this.lblRepeticoes.AutoSize = true;
            this.lblRepeticoes.Font = new System.Drawing.Font("Arial", 11F);
            this.lblRepeticoes.Location = new System.Drawing.Point(30, 391);
            this.lblRepeticoes.Name = "lblRepeticoes";
            this.lblRepeticoes.Size = new System.Drawing.Size(86, 17);
            this.lblRepeticoes.TabIndex = 43;
            this.lblRepeticoes.Text = "Repetições:";
            // 
            // txtRepeticoes
            // 
            this.txtRepeticoes.Font = new System.Drawing.Font("Arial", 11F);
            this.txtRepeticoes.Location = new System.Drawing.Point(33, 411);
            this.txtRepeticoes.Name = "txtRepeticoes";
            this.txtRepeticoes.Size = new System.Drawing.Size(237, 24);
            this.txtRepeticoes.TabIndex = 42;
            this.txtRepeticoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRepeticoes_KeyPress);
            // 
            // lblNomeInstrutor
            // 
            this.lblNomeInstrutor.AutoSize = true;
            this.lblNomeInstrutor.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeInstrutor.Location = new System.Drawing.Point(30, 69);
            this.lblNomeInstrutor.Name = "lblNomeInstrutor";
            this.lblNomeInstrutor.Size = new System.Drawing.Size(65, 17);
            this.lblNomeInstrutor.TabIndex = 45;
            this.lblNomeInstrutor.Text = "Instrutor:";
            // 
            // txtNomeInstrutor
            // 
            this.txtNomeInstrutor.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNomeInstrutor.Location = new System.Drawing.Point(33, 89);
            this.txtNomeInstrutor.Name = "txtNomeInstrutor";
            this.txtNomeInstrutor.ReadOnly = true;
            this.txtNomeInstrutor.Size = new System.Drawing.Size(237, 24);
            this.txtNomeInstrutor.TabIndex = 44;
            // 
            // lblNomeAparelho
            // 
            this.lblNomeAparelho.AutoSize = true;
            this.lblNomeAparelho.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeAparelho.Location = new System.Drawing.Point(30, 196);
            this.lblNomeAparelho.Name = "lblNomeAparelho";
            this.lblNomeAparelho.Size = new System.Drawing.Size(69, 17);
            this.lblNomeAparelho.TabIndex = 36;
            this.lblNomeAparelho.Text = "Aparelho:";
            // 
            // txtNomeAparelho
            // 
            this.txtNomeAparelho.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNomeAparelho.Location = new System.Drawing.Point(33, 216);
            this.txtNomeAparelho.Name = "txtNomeAparelho";
            this.txtNomeAparelho.ReadOnly = true;
            this.txtNomeAparelho.Size = new System.Drawing.Size(237, 24);
            this.txtNomeAparelho.TabIndex = 34;
            // 
            // cbExercicios
            // 
            this.cbExercicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExercicios.Font = new System.Drawing.Font("Arial", 11F);
            this.cbExercicios.FormattingEnabled = true;
            this.cbExercicios.Location = new System.Drawing.Point(33, 151);
            this.cbExercicios.Name = "cbExercicios";
            this.cbExercicios.Size = new System.Drawing.Size(237, 25);
            this.cbExercicios.TabIndex = 46;
            this.cbExercicios.SelectedIndexChanged += new System.EventHandler(this.cbExercicios_SelectedIndexChanged);
            // 
            // lblTipoEx
            // 
            this.lblTipoEx.AutoSize = true;
            this.lblTipoEx.Font = new System.Drawing.Font("Arial", 11F);
            this.lblTipoEx.Location = new System.Drawing.Point(30, 262);
            this.lblTipoEx.Name = "lblTipoEx";
            this.lblTipoEx.Size = new System.Drawing.Size(123, 17);
            this.lblTipoEx.TabIndex = 48;
            this.lblTipoEx.Text = "Tipo do Exercicio:";
            // 
            // txtTipoEx
            // 
            this.txtTipoEx.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTipoEx.Location = new System.Drawing.Point(33, 282);
            this.txtTipoEx.Name = "txtTipoEx";
            this.txtTipoEx.ReadOnly = true;
            this.txtTipoEx.Size = new System.Drawing.Size(237, 24);
            this.txtTipoEx.TabIndex = 47;
            // 
            // frmCadastroExercicioTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 515);
            this.ControlBox = false;
            this.Controls.Add(this.lblTipoEx);
            this.Controls.Add(this.txtTipoEx);
            this.Controls.Add(this.cbExercicios);
            this.Controls.Add(this.lblNomeInstrutor);
            this.Controls.Add(this.txtNomeInstrutor);
            this.Controls.Add(this.lblRepeticoes);
            this.Controls.Add(this.txtRepeticoes);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblNomeAparelho);
            this.Controls.Add(this.lblNomeExercicio);
            this.Controls.Add(this.txtNomeAparelho);
            this.Controls.Add(this.lblCodigoUsuario);
            this.Controls.Add(this.txtCodigoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroExercicioTreino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Treino";
            this.Load += new System.EventHandler(this.frmCadastroExercicioTreino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeries;
        public System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNomeExercicio;
        private System.Windows.Forms.Label lblCodigoUsuario;
        public System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.Label lblRepeticoes;
        public System.Windows.Forms.TextBox txtRepeticoes;
        private System.Windows.Forms.Label lblNomeInstrutor;
        public System.Windows.Forms.TextBox txtNomeInstrutor;
        private System.Windows.Forms.Label lblNomeAparelho;
        public System.Windows.Forms.TextBox txtNomeAparelho;
        private System.Windows.Forms.ComboBox cbExercicios;
        private System.Windows.Forms.Label lblTipoEx;
        public System.Windows.Forms.TextBox txtTipoEx;
    }
}