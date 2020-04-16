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

namespace SmartPersonal.View
{
    public partial class frmConsultarInstrutor : Form
    {
        UsuarioController u = new UsuarioController();

        public frmConsultarInstrutor()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                dg1.Rows.Clear();
                dg1.Refresh();

                if (txtKeyWord.Text == "")
                {
                    MessageBox.Show("Digite uma palavra-chave para pesquisar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    if (rdbtnNome.Checked == true)
                    {
                        string keyword = (txtKeyWord.Text) + "%";
                        string tipo = "nome_usuario";

                        u.tipoUsuario = 1;
                        u.consultarUsuarios(dg1, tipo, keyword, u.tipoUsuario);
                    }

                    if (rdbtnLogin.Checked == true)
                    {
                        string keyword = (txtKeyWord.Text) + "%";
                        string tipo = "login_usuario";

                        u.tipoUsuario = 1;
                        u.consultarUsuarios(dg1, tipo, keyword, u.tipoUsuario);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar instrutor! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                u.codigo = int.Parse(dg1.CurrentRow.Cells[("id_usuario")].Value.ToString());
                u.nome = dg1.CurrentRow.Cells[(Convert.ToString("nome_usuario"))].Value.ToString();
                u.login = dg1.CurrentRow.Cells[(Convert.ToString("login_usuario"))].Value.ToString();

                DialogResult selecao = MessageBox.Show("Tem certeza que deseja alterar os dados do instrutor selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    frmAlterarInstrutor frm = new frmAlterarInstrutor();
                    frm.MdiParent = this.ParentForm;
                    this.Close();

                    frm.Show();

                    frm.txtCodigo.Text = Convert.ToString(u.codigo);
                    frm.txtNome.Text = u.nome;
                    frm.txtLogin.Text = u.login;
                }
            }
            catch
            {
                MessageBox.Show("Nenhum instrutor selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(dg1.CurrentRow.Cells[("id_usuario")].Value.ToString());
                DialogResult selecao = MessageBox.Show("Tem certeza que deseja excluir o cadastro selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    u.excluirUsuario(codigo);

                    if (rdbtnNome.Checked == true)
                    {
                        string keyword = (txtKeyWord.Text) + "%";
                        string tipo = "nome_usuario";

                        u.tipoUsuario = 1;
                        u.consultarUsuarios(dg1, tipo, keyword, u.tipoUsuario);
                    }

                    if (rdbtnLogin.Checked == true)
                    {
                        string keyword = (txtKeyWord.Text) + "%";
                        string tipo = "login_usuario";

                        u.tipoUsuario = 1;
                        u.consultarUsuarios(dg1, tipo, keyword, u.tipoUsuario);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Nenhum instrutor selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtKeyWord.Text = "";
            dg1.Rows.Clear();
            dg1.Refresh();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

        private void frmConsultarInstrutor_Load(object sender, EventArgs e)
        {
            dg1.DefaultCellStyle.Font = new Font("Arial", 9);
            dg1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
        }
    }
}
