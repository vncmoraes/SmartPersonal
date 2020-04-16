using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartPersonal.Controller;
using MySql.Data.MySqlClient;

namespace SmartPersonal.View
{
    public partial class frmMeusDados : Form
    {
        Conexao c = new Conexao();
        UsuarioController u = new UsuarioController();

        int validaSenha = 0;

        public frmMeusDados()
        {
            InitializeComponent();
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
            confirmaSenha = txtConfirmaSenha.Text;

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

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            string confirmaSenha, senha;

            senha = txtSenha.Text;
            confirmaSenha = txtConfirmaSenha.Text;

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                u.codigo = Convert.ToInt32(txtCodigo.Text);

                u.puxarDadosCliente(u.codigo);

                string login = u.login;

                u.nome = txtNome.Text;
                u.login = txtLogin.Text;
                u.senha = txtSenha.Text;

                string confirmaSenha = txtConfirmaSenha.Text;

                string q = "select login_usuario from tcc.usuarios where login_usuario='" + u.login + "'";

                c.abrirConexao();

                MySqlCommand verificaLogin = new MySqlCommand(q, c.mcon);

                MySqlDataReader readerLogin = verificaLogin.ExecuteReader();

                if (readerLogin.Read() && u.login != login)
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
                    if (u.nome == "" || u.login == "" || u.senha == "" || confirmaSenha == "")
                    {
                        MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        c.fecharConexao();
                    }
                    else if (u.senha != confirmaSenha)
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
                        u.tipoUsuario = 0;
                        u.alterarUsuario(u.codigo, u.tipoUsuario);
                        this.Close();

                        MessageBox.Show("Seus dados foram alterados, relogue para que as alterações tenham efeito!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar seus dados! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmMeusDados_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            txtConfirmaSenha.UseSystemPasswordChar = true;
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

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar)) || (char.IsDigit(e.KeyChar)));
        }
    }
}
