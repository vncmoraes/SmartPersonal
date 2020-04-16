using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartPersonal;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using SmartPersonal.Controller;

namespace SmartPersonal
{
    public partial class frmCadastroCliente : Form
    {
        int validaSenha = 0;

        Conexao c = new Conexao();
        UsuarioController u = new UsuarioController();

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string confirmaSenha = "";

                u.nome = txtNome.Text;
                u.datanasc = txtDataNasc.Text;
                u.sexo = cbSexo.Text;
                u.email = txtEmail.Text;
                u.login = txtLogin.Text;
                u.senha = txtSenha.Text;
                confirmaSenha = txtConfirmaSenha.Text;
                u.tipoUsuario = 2;
                u.status = 0;
                u.reset = 0;

                if (txtPeso.Text != "" && txtAltura.Text != "")
                {
                    u.peso = Convert.ToDouble(txtPeso.Text);
                    u.altura = Convert.ToDouble(txtAltura.Text);
                }
                else
                {
                    MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                string q = "select login_usuario from tcc.usuarios where login_usuario='" + u.login + "'";
                string w = "select email_usuario from tcc.usuarios where email_usuario='" + u.email + "'";

                c.abrirConexao();

                MySqlCommand verificaLogin = new MySqlCommand(q, c.mcon);
                MySqlCommand verificaEmail = new MySqlCommand(w, c.mcon);

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
                    readerLogin.Close();
                    MySqlDataReader readerEmail = verificaEmail.ExecuteReader();

                    if (readerEmail.Read())
                    {
                        if (u.email == "")
                        {
                            MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            c.fecharConexao();
                        }
                        else
                        {
                            MessageBox.Show("Esse email já está em uso, por favor utilize outro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            readerEmail.Close();
                            c.fecharConexao();
                        }
                    }
                    else
                    {
                        int validaData = 0;
                        int validaEmail = 0;

                        try
                        {
                            var email = new System.Net.Mail.MailAddress(u.email);
                        }
                        catch
                        {
                            validaEmail += 1;
                        }

                        try
                        {
                            DateTime dt = DateTime.ParseExact(u.datanasc, "d/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        }
                        catch
                        {
                            validaData += 1;
                        }

                        if (u.nome == "" || u.peso == 0 || u.altura == 0 || u.sexo == "" || u.email == "" || u.login == "" || u.senha == "" || confirmaSenha == "")
                        {
                            MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            c.fecharConexao();
                        }
                        else if (confirmaSenha != u.senha)
                        {
                            MessageBox.Show("As senhas não conferem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            c.fecharConexao();
                        }
                        else if (validaData >= 1)
                        {
                            MessageBox.Show("A data digita é inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            c.fecharConexao();
                        }
                        else if (validaEmail >= 1)
                        {
                            MessageBox.Show("O email digitado é inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            readerEmail.Close();
                            c.fecharConexao();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o cliente! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtDataNasc.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";

        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            txtConfirmaSenha.UseSystemPasswordChar = true;
        }


        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar)) || (char.IsDigit(e.KeyChar)));
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == Char.Parse("."));
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || e.KeyChar == Char.Parse("."));
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();
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