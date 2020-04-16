namespace SmartPersonal.View
{
    partial class frmAlterarExercicioTreino
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
            this.lblTipoEx = new System.Windows.Forms.Label();
            this.txtTipoEx = new System.Windows.Forms.TextBox();
            this.cbExercicios = new System.Windows.Forms.ComboBox();
            this.lblInstrutor = new System.Windows.Forms.Label();
            this.txtNomeInstrutor = new System.Windows.Forms.TextBox();
            this.lblNomeAparelho = new System.Windows.Forms.Label();
            this.lblNomeExercicio = new System.Windows.Forms.Label();
            this.txtNomeAparelho = new System.Windows.Forms.TextBox();
            this.lblCodigoTreino = new System.Windows.Forms.Label();
            this.txtCodigoTreino = new System.Windows.Forms.TextBox();
            this.lblRepeticoes = new System.Windows.Forms.Label();
            this.txtRepeticoes = new System.Windows.Forms.TextBox();
            this.lblSeries = new System.Windows.Forms.Label();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoEx
            // 
            this.lblTipoEx.AutoSize = true;
            this.lblTipoEx.Font = new System.Drawing.Font("Arial", 11F);
            this.lblTipoEx.Location = new System.Drawing.Point(25, 261);
            this.lblTipoEx.Name = "lblTipoEx";
            this.lblTipoEx.Size = new System.Drawing.Size(123, 17);
            this.lblTipoEx.TabIndex = 58;
            this.lblTipoEx.Text = "Tipo do Exercicio:";
            // 
            // txtTipoEx
            // 
            this.txtTipoEx.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTipoEx.Location = new System.Drawing.Point(28, 281);
            this.txtTipoEx.Name = "txtTipoEx";
            this.txtTipoEx.ReadOnly = true;
            this.txtTipoEx.Size = new System.Drawing.Size(240, 24);
            this.txtTipoEx.TabIndex = 57;
            // 
            // cbExercicios
            // 
            this.cbExercicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExercicios.Font = new System.Drawing.Font("Arial", 11F);
            this.cbExercicios.FormattingEnabled = true;
            this.cbExercicios.Location = new System.Drawing.Point(28, 150);
            this.cbExercicios.Name = "cbExercicios";
            this.cbExercicios.Size = new System.Drawing.Size(240, 25);
            this.cbExercicios.TabIndex = 56;
            this.cbExercicios.SelectedIndexChanged += new System.EventHandler(this.cbExercicios_SelectedIndexChanged);
            // 
            // lblInstrutor
            // 
            this.lblInstrutor.AutoSize = true;
            this.lblInstrutor.Font = new System.Drawing.Font("Arial", 11F);
            this.lblInstrutor.Location = new System.Drawing.Point(25, 68);
            this.lblInstrutor.Name = "lblInstrutor";
            this.lblInstrutor.Size = new System.Drawing.Size(65, 17);
            this.lblInstrutor.TabIndex = 55;
            this.lblInstrutor.Text = "Instrutor:";
            // 
            // txtNomeInstrutor
            // 
            this.txtNomeInstrutor.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNomeInstrutor.Location = new System.Drawing.Point(28, 88);
            this.txtNomeInstrutor.Name = "txtNomeInstrutor";
            this.txtNomeInstrutor.ReadOnly = true;
            this.txtNomeInstrutor.Size = new System.Drawing.Size(240, 24);
            this.txtNomeInstrutor.TabIndex = 54;
            // 
            // lblNomeAparelho
            // 
            this.lblNomeAparelho.AutoSize = true;
            this.lblNomeAparelho.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeAparelho.Location = new System.Drawing.Point(25, 195);
            this.lblNomeAparelho.Name = "lblNomeAparelho";
            this.lblNomeAparelho.Size = new System.Drawing.Size(69, 17);
            this.lblNomeAparelho.TabIndex = 53;
            this.lblNomeAparelho.Text = "Aparelho:";
            // 
            // lblNomeExercicio
            // 
            this.lblNomeExercicio.AutoSize = true;
            this.lblNomeExercicio.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNomeExercicio.Location = new System.Drawing.Point(25, 130);
            this.lblNomeExercicio.Name = "lblNomeExercicio";
            this.lblNomeExercicio.Size = new System.Drawing.Size(72, 17);
            this.lblNomeExercicio.TabIndex = 52;
            this.lblNomeExercicio.Text = "Exercício:";
            // 
            // txtNomeAparelho
            // 
            this.txtNomeAparelho.Font = new System.Drawing.Font("Arial", 11F);
            this.txtNomeAparelho.Location = new System.Drawing.Point(28, 215);
            this.txtNomeAparelho.Name = "txtNomeAparelho";
            this.txtNomeAparelho.ReadOnly = true;
            this.txtNomeAparelho.Size = new System.Drawing.Size(240, 24);
            this.txtNomeAparelho.TabIndex = 51;
            // 
            // lblCodigoTreino
            // 
            this.lblCodigoTreino.AutoSize = true;
            this.lblCodigoTreino.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCodigoTreino.Location = new System.Drawing.Point(25, 25);
            this.lblCodigoTreino.Name = "lblCodigoTreino";
            this.lblCodigoTreino.Size = new System.Drawing.Size(122, 17);
            this.lblCodigoTreino.TabIndex = 50;
            this.lblCodigoTreino.Text = "Código do Treino:";
            // 
            // txtCodigoTreino
            // 
            this.txtCodigoTreino.Font = new System.Drawing.Font("Arial", 11F);
            this.txtCodigoTreino.Location = new System.Drawing.Point(153, 22);
            this.txtCodigoTreino.Name = "txtCodigoTreino";
            this.txtCodigoTreino.ReadOnly = true;
            this.txtCodigoTreino.Size = new System.Drawing.Size(56, 24);
            this.txtCodigoTreino.TabIndex = 49;
            // 
            // lblRepeticoes
            // 
            this.lblRepeticoes.AutoSize = true;
            this.lblRepeticoes.Font = new System.Drawing.Font("Arial", 11F);
            this.lblRepeticoes.Location = new System.Drawing.Point(25, 382);
            this.lblRepeticoes.Name = "lblRepeticoes";
            this.lblRepeticoes.Size = new System.Drawing.Size(86, 17);
            this.lblRepeticoes.TabIndex = 65;
            this.lblRepeticoes.Text = "Repetições:";
            // 
            // txtRepeticoes
            // 
            this.txtRepeticoes.Font = new System.Drawing.Font("Arial", 11F);
            this.txtRepeticoes.Location = new System.Drawing.Point(28, 402);
            this.txtRepeticoes.Name = "txtRepeticoes";
            this.txtRepeticoes.Size = new System.Drawing.Size(240, 24);
            this.txtRepeticoes.TabIndex = 64;
            this.txtRepeticoes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRepeticoes_KeyPress);
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Font = new System.Drawing.Font("Arial", 11F);
            this.lblSeries.Location = new System.Drawing.Point(25, 318);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(54, 17);
            this.lblSeries.TabIndex = 63;
            this.lblSeries.Text = "Séries:";
            // 
            // txtSeries
            // 
            this.txtSeries.Font = new System.Drawing.Font("Arial", 11F);
            this.txtSeries.Location = new System.Drawing.Point(28, 338);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(240, 24);
            this.txtSeries.TabIndex = 62;
            this.txtSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeries_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(184, 462);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 27);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(98, 462);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 27);
            this.btnLimpar.TabIndex = 60;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 11F);
            this.btnAlterar.Location = new System.Drawing.Point(28, 462);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(64, 27);
            this.btnAlterar.TabIndex = 59;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmAlterarExercicioTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 506);
            this.ControlBox = false;
            this.Controls.Add(this.lblRepeticoes);
            this.Controls.Add(this.txtRepeticoes);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblTipoEx);
            this.Controls.Add(this.txtTipoEx);
            this.Controls.Add(this.cbExercicios);
            this.Controls.Add(this.lblInstrutor);
            this.Controls.Add(this.txtNomeInstrutor);
            this.Controls.Add(this.lblNomeAparelho);
            this.Controls.Add(this.lblNomeExercicio);
            this.Controls.Add(this.txtNomeAparelho);
            this.Controls.Add(this.lblCodigoTreino);
            this.Controls.Add(this.txtCodigoTreino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAlterarExercicioTreino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Treino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoEx;
        public System.Windows.Forms.TextBox txtTipoEx;
        public System.Windows.Forms.ComboBox cbExercicios;
        private System.Windows.Forms.Label lblInstrutor;
        public System.Windows.Forms.TextBox txtNomeInstrutor;
        private System.Windows.Forms.Label lblNomeAparelho;
        private System.Windows.Forms.Label lblNomeExercicio;
        public System.Windows.Forms.TextBox txtNomeAparelho;
        private System.Windows.Forms.Label lblCodigoTreino;
        public System.Windows.Forms.TextBox txtCodigoTreino;
        public System.Windows.Forms.Label lblRepeticoes;
        public System.Windows.Forms.TextBox txtRepeticoes;
        public System.Windows.Forms.Label lblSeries;
        public System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
    }
}