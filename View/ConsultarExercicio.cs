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
    public partial class frmConsultarExercicio : Form
    {
        public static string nomeAparelho = "";
        public static string tipoExercicio = "";

        ExercicioController ex = new ExercicioController();

        public frmConsultarExercicio()
        {
            InitializeComponent();
        }

        private void frmConsultarExercicio_Load(object sender, EventArgs e)
        {
            ExercicioController.verificaExercicio = 0;

            dg1.DefaultCellStyle.Font = new Font("Arial", 9);
            dg1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            ex.consultarExercicios(dg1);

            if (ExercicioController.verificaExercicio >= 1)
            {
                this.Hide();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ex.id_exercicio = int.Parse(dg1.CurrentRow.Cells[("id_exercicio")].Value.ToString());
                ex.nome_exercicio = dg1.CurrentRow.Cells[(Convert.ToString("nome_exercicio"))].Value.ToString();
                nomeAparelho = dg1.CurrentRow.Cells[(Convert.ToString("nome_aparelho"))].Value.ToString();
                tipoExercicio = dg1.CurrentRow.Cells[(Convert.ToString("tipo_exercicio"))].Value.ToString();

                DialogResult selecao = MessageBox.Show("Tem certeza que deseja alterar os dados do cadastro selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    frmAlterarExercicio frm = new frmAlterarExercicio();
                    frm.MdiParent = this.ParentForm;
                    this.Close();

                    frm.Show();

                    frm.txtCodigo.Text = Convert.ToString(ex.id_exercicio);
                    frm.txtNomeEx.Text = ex.nome_exercicio;

                }


            }
            catch
            {
                MessageBox.Show("Nenhum exercício selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ex.id_exercicio = int.Parse(dg1.CurrentRow.Cells[("id_exercicio")].Value.ToString());

                DialogResult selecao = MessageBox.Show("Tem certeza que deseja excluir o exercício selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    ex.excluirExercicio(ex.id_exercicio);
                    ex.consultarExercicios(dg1);
                }
            }
            catch
            {
                MessageBox.Show("Nenhum exercício selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
