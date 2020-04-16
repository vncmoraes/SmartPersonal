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
    public partial class frmConsultarTreino : Form
    {
        TreinoController t = new TreinoController();
        Usuario u = new Usuario();

        public static int codigoUsuario;
        public static string nomeUsuario;

        public frmConsultarTreino()
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

                        t.consultarCliente(dg1, tipo, keyword);
                    }

                    if (rdbtnEmail.Checked == true)
                    {
                        string keyword = (txtKeyWord.Text) + "%";
                        string tipo = "email_usuario";

                        t.consultarCliente(dg1, tipo, keyword);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar cliente! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtKeyWord.Text = "";
            dg1.Rows.Clear();
            dg1.Refresh();
        }


        private void btnExercicios_Click(object sender, EventArgs e)
        {
            try
            {
                t.id_usuario = int.Parse(dg1.CurrentRow.Cells[("id_usuario")].Value.ToString());

                DialogResult selecao = MessageBox.Show("Deseja cadastrar um novo exercício para o usuário selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    frmCadastroExercicioTreino frm = new frmCadastroExercicioTreino();
                    frm.MdiParent = this.ParentForm;
                    this.Close();

                    frm.Show();

                    frm.txtCodigoUsuario.Text = t.id_usuario.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Nenhum cliente selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTreino_Click(object sender, EventArgs e)
        {
            try
            {
                codigoUsuario = int.Parse(dg1.CurrentRow.Cells[("id_usuario")].Value.ToString());

                nomeUsuario = dg1.CurrentRow.Cells[("nome_usuario")].Value.ToString();

                DialogResult selecao = MessageBox.Show("Deseja ver a tabela de exercicios do usuário selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    frmConsultarTreinoUser frm = new frmConsultarTreinoUser();
                    frm.MdiParent = this.ParentForm;
                    this.Hide();

                    try
                    {
                        frm.Show();
                    }
                    catch
                    {
                        this.Show();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nenhum cliente selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void frmConsultarTreino_Load(object sender, EventArgs e)
        {
            dg1.DefaultCellStyle.Font = new Font("Arial", 9);
            dg1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
        }
    }
}
