using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmartPersonal.View;
using System.Runtime.InteropServices;

namespace SmartPersonal.View
{
    public partial class frmLogin : Form
    {
        public static string nomeInstrutor;
        public static int codigoSessao;
        public static string nomeSessao;
        public static string loginSessao;

        Conexao c = new Conexao();
        Usuario u = new Usuario();
        Treino t = new Treino();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string login, senha;

                login = txtLogin.Text;
                senha = txtSenha.Text;

                string q = "select id_usuario, nome_usuario,login_usuario,senha_usuario,tipo_usuario from tcc.usuarios where login_usuario='" + login + "'";
                c.abrirConexao();

                MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

                MySqlDataReader reader = puxarDados.ExecuteReader();

                if (reader.Read())
                {
                    u.codigo = reader.GetInt32("id_usuario");
                    t.nome_instrutor = reader.GetString("nome_usuario");
                    u.login = reader.GetString("login_usuario");
                    u.senha = reader.GetString("senha_usuario");
                    u.tipoUsuario = reader.GetInt32("tipo_usuario");

                    u.senhacrip = MD5Hash.CalculaHash(senha);

                    if (u.senhacrip == u.senha)
                    {
                        if (u.tipoUsuario == 0 || u.tipoUsuario == 1)
                        {
                            AutoClosingMessageBox.Show("Login efetuado com sucesso!", "Aviso", 1500, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmTelaPrincipal frm = new frmTelaPrincipal();
                            frm.tipoUsuario = u.tipoUsuario;
                            this.Close();

                            frm.Show();

                            string nomeCompleto = t.nome_instrutor;

                            var nomes = nomeCompleto.Split(' ');
                            string primeiroNome = nomes[0];

                            frm.lblNomeUser.Text += nomes[0];
                            frm.lblHora.Text = DateTime.Now.ToString();

                            nomeInstrutor = nomeCompleto;

                            codigoSessao = u.codigo;
                            nomeSessao = t.nome_instrutor;
                            loginSessao = u.login;
                        }
                        else
                        {
                            MessageBox.Show("Esse usuário não possui permissão para entrar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtLogin.Text = "";
                            txtSenha.Text = "";
                        }
                    }
                    else
                    {
                        if (senha != "")
                        {
                            MessageBox.Show("Senha incorreta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtSenha.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Campos Inválidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    if (login == "" || senha == "")
                    {
                        MessageBox.Show("Campos Inválidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSenha.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("O usuário não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                    }
                }


                reader.Close();
                c.fecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao logar! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string texto, string titulo, int tempo, MessageBoxButtons botoes, MessageBoxIcon icone)
            {
                _caption = titulo;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, tempo, System.Threading.Timeout.Infinite);
                MessageBox.Show(texto, titulo, botoes, icone);

            }

            public static void Show(string texto, string titulo, int tempo, MessageBoxButtons botoes, MessageBoxIcon icone)
            {
                new AutoClosingMessageBox(texto, titulo, tempo, botoes, icone);
            }

            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow(null, _caption);
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }
    }
}
