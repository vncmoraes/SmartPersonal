namespace SmartPersonal.View
{
    partial class frmTelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.menuPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnUsuario = new System.Windows.Forms.ToolStripSplitButton();
            this.menuCadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.separador1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAparelho = new System.Windows.Forms.ToolStripSplitButton();
            this.menuCadastrarAparelho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarAparelho = new System.Windows.Forms.ToolStripMenuItem();
            this.separador2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.separador5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExercicio = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuCadastrarExercicio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarExercicio = new System.Windows.Forms.ToolStripMenuItem();
            this.separador3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTreino = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuConsultarTreino = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTrocarConta = new System.Windows.Forms.ToolStripButton();
            this.separador4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMeusDados = new System.Windows.Forms.ToolStripButton();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.White;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuario,
            this.separador1,
            this.btnAparelho,
            this.separador2,
            this.btnSair,
            this.separador5,
            this.btnExercicio,
            this.separador3,
            this.btnTreino,
            this.btnTrocarConta,
            this.separador4,
            this.btnMeusDados});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(936, 81);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "16/87/1999 22:25:33";
            this.menuPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPrincipal_MouseDown);
            // 
            // btnUsuario
            // 
            this.btnUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarCliente,
            this.menuConsultarCliente,
            this.toolStripMenuItem1,
            this.menuCadastrarFuncionario,
            this.menuConsultarFuncionario});
            this.btnUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsuario.ImageTransparentColor = System.Drawing.Color.White;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.btnUsuario.Size = new System.Drawing.Size(90, 78);
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // menuCadastrarCliente
            // 
            this.menuCadastrarCliente.Name = "menuCadastrarCliente";
            this.menuCadastrarCliente.Size = new System.Drawing.Size(204, 22);
            this.menuCadastrarCliente.Text = "Cadastrar Cliente";
            this.menuCadastrarCliente.Click += new System.EventHandler(this.menuCadastrarUsuario_Click);
            // 
            // menuConsultarCliente
            // 
            this.menuConsultarCliente.Name = "menuConsultarCliente";
            this.menuConsultarCliente.Size = new System.Drawing.Size(204, 22);
            this.menuConsultarCliente.Text = "Consultar Cliente";
            this.menuConsultarCliente.Click += new System.EventHandler(this.menuConsultarUsuario_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // menuCadastrarFuncionario
            // 
            this.menuCadastrarFuncionario.Name = "menuCadastrarFuncionario";
            this.menuCadastrarFuncionario.Size = new System.Drawing.Size(204, 22);
            this.menuCadastrarFuncionario.Text = "Cadastrar Instrutor";
            this.menuCadastrarFuncionario.Click += new System.EventHandler(this.menuCadastrarFuncionario_Click);
            // 
            // menuConsultarFuncionario
            // 
            this.menuConsultarFuncionario.Name = "menuConsultarFuncionario";
            this.menuConsultarFuncionario.Size = new System.Drawing.Size(204, 22);
            this.menuConsultarFuncionario.Text = "Consultar Instrutor";
            this.menuConsultarFuncionario.Click += new System.EventHandler(this.menuConsultarFuncionario_Click);
            // 
            // separador1
            // 
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(6, 81);
            // 
            // btnAparelho
            // 
            this.btnAparelho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAparelho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarAparelho,
            this.menuConsultarAparelho});
            this.btnAparelho.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAparelho.Image = ((System.Drawing.Image)(resources.GetObject("btnAparelho.Image")));
            this.btnAparelho.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAparelho.ImageTransparentColor = System.Drawing.Color.White;
            this.btnAparelho.Name = "btnAparelho";
            this.btnAparelho.Padding = new System.Windows.Forms.Padding(5);
            this.btnAparelho.Size = new System.Drawing.Size(90, 78);
            this.btnAparelho.Text = "Aparelho";
            this.btnAparelho.ButtonClick += new System.EventHandler(this.btnAparelho_ButtonClick);
            // 
            // menuCadastrarAparelho
            // 
            this.menuCadastrarAparelho.Name = "menuCadastrarAparelho";
            this.menuCadastrarAparelho.Size = new System.Drawing.Size(212, 22);
            this.menuCadastrarAparelho.Text = "Cadastrar Aparelho";
            this.menuCadastrarAparelho.Click += new System.EventHandler(this.menuCadastrarAparelho_Click);
            // 
            // menuConsultarAparelho
            // 
            this.menuConsultarAparelho.Name = "menuConsultarAparelho";
            this.menuConsultarAparelho.Size = new System.Drawing.Size(212, 22);
            this.menuConsultarAparelho.Text = "Consultar Aparelho";
            this.menuConsultarAparelho.Click += new System.EventHandler(this.menuConsultarAparelho_Click);
            // 
            // separador2
            // 
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(6, 81);
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.White;
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5);
            this.btnSair.Size = new System.Drawing.Size(61, 78);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // separador5
            // 
            this.separador5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.separador5.Name = "separador5";
            this.separador5.Size = new System.Drawing.Size(6, 81);
            // 
            // btnExercicio
            // 
            this.btnExercicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExercicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarExercicio,
            this.menuConsultarExercicio});
            this.btnExercicio.Font = new System.Drawing.Font("Arial", 12F);
            this.btnExercicio.Image = ((System.Drawing.Image)(resources.GetObject("btnExercicio.Image")));
            this.btnExercicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExercicio.ImageTransparentColor = System.Drawing.Color.White;
            this.btnExercicio.Name = "btnExercicio";
            this.btnExercicio.Padding = new System.Windows.Forms.Padding(5);
            this.btnExercicio.Size = new System.Drawing.Size(87, 78);
            this.btnExercicio.Text = "Exercício";
            // 
            // menuCadastrarExercicio
            // 
            this.menuCadastrarExercicio.Name = "menuCadastrarExercicio";
            this.menuCadastrarExercicio.Size = new System.Drawing.Size(214, 22);
            this.menuCadastrarExercicio.Text = "Cadastrar Exercício";
            this.menuCadastrarExercicio.Click += new System.EventHandler(this.menuCadastrarExercicio_Click);
            // 
            // menuConsultarExercicio
            // 
            this.menuConsultarExercicio.Name = "menuConsultarExercicio";
            this.menuConsultarExercicio.Size = new System.Drawing.Size(214, 22);
            this.menuConsultarExercicio.Text = "Consultar Exercício";
            this.menuConsultarExercicio.Click += new System.EventHandler(this.menuConsultarExercicio_Click);
            // 
            // separador3
            // 
            this.separador3.Name = "separador3";
            this.separador3.Size = new System.Drawing.Size(6, 81);
            // 
            // btnTreino
            // 
            this.btnTreino.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTreino.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsultarTreino});
            this.btnTreino.Font = new System.Drawing.Font("Arial", 12F);
            this.btnTreino.Image = ((System.Drawing.Image)(resources.GetObject("btnTreino.Image")));
            this.btnTreino.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTreino.ImageTransparentColor = System.Drawing.Color.White;
            this.btnTreino.Name = "btnTreino";
            this.btnTreino.Padding = new System.Windows.Forms.Padding(5);
            this.btnTreino.Size = new System.Drawing.Size(87, 78);
            this.btnTreino.Text = "Treino";
            this.btnTreino.Click += new System.EventHandler(this.btnTreino_Click);
            // 
            // menuConsultarTreino
            // 
            this.menuConsultarTreino.Name = "menuConsultarTreino";
            this.menuConsultarTreino.Size = new System.Drawing.Size(189, 22);
            this.menuConsultarTreino.Text = "Consultar Treino";
            this.menuConsultarTreino.Click += new System.EventHandler(this.menuConsultarTreino_Click);
            // 
            // btnTrocarConta
            // 
            this.btnTrocarConta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTrocarConta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTrocarConta.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocarConta.Image")));
            this.btnTrocarConta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTrocarConta.ImageTransparentColor = System.Drawing.Color.White;
            this.btnTrocarConta.Name = "btnTrocarConta";
            this.btnTrocarConta.Size = new System.Drawing.Size(56, 78);
            this.btnTrocarConta.Text = "Trocar de Conta";
            this.btnTrocarConta.Click += new System.EventHandler(this.btnTrocarConta_Click);
            // 
            // separador4
            // 
            this.separador4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.separador4.Name = "separador4";
            this.separador4.Size = new System.Drawing.Size(6, 81);
            // 
            // btnMeusDados
            // 
            this.btnMeusDados.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMeusDados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMeusDados.Image = ((System.Drawing.Image)(resources.GetObject("btnMeusDados.Image")));
            this.btnMeusDados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMeusDados.ImageTransparentColor = System.Drawing.Color.White;
            this.btnMeusDados.Name = "btnMeusDados";
            this.btnMeusDados.Size = new System.Drawing.Size(56, 78);
            this.btnMeusDados.Text = "Meus Dados";
            this.btnMeusDados.Click += new System.EventHandler(this.btnMeusDados_Click);
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.BackColor = System.Drawing.Color.White;
            this.lblNomeUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomeUser.Location = new System.Drawing.Point(580, 9);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Padding = new System.Windows.Forms.Padding(5);
            this.lblNomeUser.Size = new System.Drawing.Size(52, 29);
            this.lblNomeUser.TabIndex = 3;
            this.lblNomeUser.Text = "Olá, ";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(581, 38);
            this.lblHora.Name = "lblHora";
            this.lblHora.Padding = new System.Windows.Forms.Padding(5);
            this.lblHora.Size = new System.Drawing.Size(10, 26);
            this.lblHora.TabIndex = 7;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(936, 713);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Personal Trainer";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip menuPrincipal;
        private System.Windows.Forms.ToolStripSplitButton btnUsuario;
        private System.Windows.Forms.ToolStripSplitButton btnAparelho;
        private System.Windows.Forms.ToolStripSeparator separador1;
        private System.Windows.Forms.ToolStripSeparator separador2;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarCliente;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarAparelho;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarAparelho;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripSeparator separador5;
        private System.Windows.Forms.ToolStripDropDownButton btnTreino;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarTreino;
        public System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.Timer timerHora;
        public System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ToolStripDropDownButton btnExercicio;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarExercicio;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarExercicio;
        private System.Windows.Forms.ToolStripSeparator separador3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarFuncionario;
        private System.Windows.Forms.ToolStripButton btnMeusDados;
        private System.Windows.Forms.ToolStripSeparator separador4;
        private System.Windows.Forms.ToolStripButton btnTrocarConta;
    }
}