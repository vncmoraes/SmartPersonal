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
        public partial class frmAlterarInstrutor : Form
        {
            UsuarioController u = new UsuarioController();
            Conexao c = new Conexao();

            public frmAlterarInstrutor()
            {
                InitializeComponent();

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
                        if (u.nome == "" || u.login == "")
                        {
                            MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            c.fecharConexao();
                        }
                        else
                        {
                            u.tipoUsuario = 1;
                            u.alterarUsuario(u.codigo, u.tipoUsuario);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar o instrutor! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnLimpar_Click(object sender, EventArgs e)
            {
                txtNome.Text = "";
                txtLogin.Text = "";
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
