using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;
using SmartPersonal.Controller;
using MySql.Data.MySqlClient;

namespace SmartPersonal.View
{
    public partial class frmAlterarCliente : Form
    {
        UsuarioController u = new UsuarioController();
        Conexao c = new Conexao();


        public frmAlterarCliente()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();
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
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                u.codigo = Convert.ToInt32(txtCodigo.Text);

                u.puxarDadosCliente(u.codigo);

                string login = u.login;
                string email = u.email;

                u.nome = txtNome.Text;
                u.datanasc = txtDataNasc.Text;
                u.sexo = cbSexo.Text;
                u.email = txtEmail.Text;
                u.login = txtLogin.Text;


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
                    readerLogin.Close();
                    MySqlDataReader readerEmail = verificaEmail.ExecuteReader();

                    if (readerEmail.Read() && u.email != email)
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
                            var emailValidado = new System.Net.Mail.MailAddress(u.email);
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

                        if (u.nome == "" || u.peso == 0 || u.altura == 0 || u.sexo == "" || u.email == "" || u.login == "")
                        {
                            MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            c.fecharConexao();
                        }
                        else if (validaData >= 1)
                        {
                            MessageBox.Show("Data Inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            c.fecharConexao();
                        }
                        else if (validaEmail >= 1)
                        {
                            MessageBox.Show("Email Inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            c.fecharConexao();
                        }
                        else
                        {
                            u.tipoUsuario = 2;
                            u.alterarUsuario(u.codigo, u.tipoUsuario);
                            this.Close();
                            readerEmail.Close();
                            c.fecharConexao();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o cliente! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar)) || (char.IsDigit(e.KeyChar)));
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
