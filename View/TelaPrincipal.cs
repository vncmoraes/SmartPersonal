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
using SmartPersonal.View;

namespace SmartPersonal.View
{
    public partial class frmTelaPrincipal : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Usuario u = new Usuario();
        public int tipoUsuario = 0;

        public frmTelaPrincipal()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 14, 14));
        }


        private void menuCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroCliente frm = new frmCadastroCliente();
                frm.MdiParent = this;

                if (Application.OpenForms["frmCadastroUsuario"] == null)
                {
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { }


        }

        private void menuConsultarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultarUsuario frm = new frmConsultarUsuario();
                frm.MdiParent = this;

                if (Application.OpenForms["frmConsultarUsuario"] == null)
                {
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            btnUsuario.ShowDropDown();
        }

        private void menuCadastrarAparelho_Click(object sender, EventArgs e)
        {
            frmCadastroAparelho frm = new frmCadastroAparelho();
            frm.MdiParent = this;

            if (Application.OpenForms["frmCadastroAparelho"] == null)
            {
                frm.Show();
            }
            else
            {
                MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAparelho_ButtonClick(object sender, EventArgs e)
        {
            btnAparelho.ShowDropDown();
        }

        private void menuConsultarAparelho_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultarAparelho frm = new frmConsultarAparelho();
                frm.MdiParent = this;

                if (Application.OpenForms["frmConsultarAparelho"] == null)
                {
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTreino_Click(object sender, EventArgs e)
        {
            btnTreino.ShowDropDown();
        }

        private void menuConsultarTreino_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultarTreino frm = new frmConsultarTreino();
                frm.MdiParent = this;

                if (Application.OpenForms["frmCadastroTreino"] == null)
                {
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void menuCadastrarExercicio_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroExercicio frm = new frmCadastroExercicio();
                frm.MdiParent = this;

                if (Application.OpenForms["frmCadastroExercicio"] == null)
                {
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { }
        }

        private void menuConsultarExercicio_Click(object sender, EventArgs e)
        {
            try
            {
                frmConsultarExercicio frm = new frmConsultarExercicio();
                frm.MdiParent = this;

                if (Application.OpenForms["frmConsultarExercicio"] == null)
                {
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { }

        }

        private void menuCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (tipoUsuario == 1)
            {
                MessageBox.Show("Você não possui permissão para cadastrar funcionário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (tipoUsuario == 0)
            {
                frmCadastroInstrutor frm = new frmCadastroInstrutor();
                frm.MdiParent = this;

                if (Application.OpenForms["frmCadastroFuncionario"] == null)
                {
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void menuConsultarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipoUsuario == 1)
                {
                    MessageBox.Show("Você não possui permissão para consultar funcionário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (tipoUsuario == 0)
                {
                    frmConsultarInstrutor frm = new frmConsultarInstrutor();
                    frm.MdiParent = this;

                    if (Application.OpenForms["frmConsultarExercicio"] == null)
                    {
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch { }
        }

        private void menuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnMeusDados_Click(object sender, EventArgs e)
        {
            try
            {
                frmMeusDados frm = new frmMeusDados();
                frm.MdiParent = this;

                if (Application.OpenForms["frmMeusDados"] == null)
                {
                    frm.Show();

                    frm.txtCodigo.Text = Convert.ToString(frmLogin.codigoSessao);
                    frm.txtNome.Text = frmLogin.nomeSessao;
                    frm.txtLogin.Text = frmLogin.loginSessao;
                }
                else
                {
                    MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { }
        }

        private void btnTrocarConta_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja trocar de conta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();

                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }

        private void menuCadastrarTreino_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadastroExercicioTreino frm = new frmCadastroExercicioTreino();
                frm.MdiParent = this;

                if (Application.OpenForms["frmCadastroExercicioTreino"] == null)
                {
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Esse formulário já está aberto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { }
        }
    }
}
