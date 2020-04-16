using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartPersonal.Controller;
using MySql.Data.MySqlClient;

namespace SmartPersonal.View
{
    public partial class frmCadastroInstrutor : Form
    {
        int validaSenha = 0;

        UsuarioController u = new UsuarioController();
        Conexao c = new Conexao();

        public frmCadastroInstrutor()
        {
            InitializeComponent();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            txtConfirmarSenha.UseSystemPasswordChar = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string confirmarSenha = "";

                u.nome = txtNome.Text;
                u.login = txtLogin.Text;
                u.senha = txtSenha.Text;
                confirmarSenha = txtConfirmarSenha.Text;

                string q = "select login_usuario from tcc.usuarios where login_usuario='" + u.login + "'";
                string w = "select email_usuario from tcc.usuarios where email_usuario='" + u.email + "'";

                c.abrirConexao();

                MySqlCommand verificaLogin = new MySqlCommand(q, c.mcon);

                MySqlDataReader readerLogin = verificaLogin.ExecuteReader();

                if (readerLogin.Read())
                {
                    if (u.login == "")
                    {
                        MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        c.fecharConexao();
                    }
                    else
                    {
                        MessageBox.Show("Esse login já está em uso, por favor utilize outro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        readerLogin.Close();
                        c.fecharConexao();
                    }
                }
                else
                {

                    u.tipoUsuario = 1;
                    u.status = 0;
                    u.reset = 0;

                    if (u.nome == "" || u.login == "" || u.senha == "" || confirmarSenha == "")
                    {
                        MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        c.fecharConexao();
                    }
                    else if (u.senha != confirmarSenha)
                    {
                        MessageBox.Show("As senhas não conferem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        c.fecharConexao();
                    }
                    else if (validaSenha >= 1)
                    {
                        MessageBox.Show("Melhore a força da senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        c.fecharConexao();
                    }
                    else
                    {
                        u.senhacrip = MD5Hash.CalculaHash(u.senha);
                        u.cadastrarUsuario(u.tipoUsuario);
                        this.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o instrutor! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtConfirmarSenha.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar)) || (char.IsDigit(e.KeyChar)));
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string senha;
            NivelSenha nivel;

            senha = txtSenha.Text;
            nivel = ForcaSenha.checarForca(senha);

            if (nivel == NivelSenha.Vazio)
            {
                lblForcaSenha.Text = "";
                validaSenha += 1;
            }

            else if (nivel == NivelSenha.MuitoFraco)
            {
                lblForcaSenha.ForeColor = System.Drawing.Color.DarkRed;
                lblForcaSenha.Text = "Muito Fraco";
                validaSenha += 1;
            }

            else if (nivel == NivelSenha.Fraco)
            {
                lblForcaSenha.ForeColor = System.Drawing.Color.Red;
                lblForcaSenha.Text = "Fraco";
                validaSenha += 1;
            }

            else if (nivel == NivelSenha.Medio)
            {
                lblForcaSenha.ForeColor = System.Drawing.Color.Orange;
                lblForcaSenha.Text = "Médio";
                validaSenha = 0;
            }

            else if (nivel == NivelSenha.Forte)
            {
                lblForcaSenha.ForeColor = System.Drawing.Color.Green;
                lblForcaSenha.Text = "Forte";
                validaSenha = 0;
            }

            else if (nivel == NivelSenha.MuitoForte)
            {
                lblForcaSenha.ForeColor = System.Drawing.Color.DarkGreen;
                lblForcaSenha.Text = "Muito Forte";
                validaSenha = 0;
            }

            string confirmaSenha, senhacf;

            senhacf = txtSenha.Text;
            confirmaSenha = txtConfirmarSenha.Text;

            if (senhacf == confirmaSenha && (senhacf != "" && confirmaSenha != ""))
            {
                lblSenhaConf.Text = "As senhas conferem";
                lblSenhaConf.ForeColor = System.Drawing.Color.Green;
            }
            else if (senhacf != confirmaSenha)
            {
                lblSenhaConf.Text = "As senhas não conferem";
                lblSenhaConf.ForeColor = System.Drawing.Color.Red;
            }
            else if (senhacf == "" || confirmaSenha == "")
            {
                lblForcaSenha.Text = "";
                lblSenhaConf.Text = "";
            }
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            string confirmaSenha, senha;

            senha = txtSenha.Text;
            confirmaSenha = txtConfirmarSenha.Text;

            if (senha == confirmaSenha && (senha != "" && confirmaSenha != ""))
            {
                lblSenhaConf.Text = "As senhas conferem";
                lblSenhaConf.ForeColor = System.Drawing.Color.Green;
            }
            else if (senha != confirmaSenha)
            {
                lblSenhaConf.Text = "As senhas não conferem";
                lblSenhaConf.ForeColor = System.Drawing.Color.Red;
            }
            else if (senha == "" || confirmaSenha == "")
            {
                lblForcaSenha.Text = "";
                lblSenhaConf.Text = "";
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
            base.WndProc(ref m);
        }
    }
}
