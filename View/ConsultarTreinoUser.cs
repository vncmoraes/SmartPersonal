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

namespace SmartPersonal.View
{
    public partial class frmConsultarTreinoUser : Form
    {
        TreinoController t = new TreinoController();

        public static int codigo;

        public frmConsultarTreinoUser()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmConsultarTreinoUser_Load(object sender, EventArgs e)
        {
            TreinoController.verificaTreino = 0;
            codigo = frmConsultarTreino.codigoUsuario;

            dg1.DefaultCellStyle.Font = new Font("Arial", 9);
            dg1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            t.consultarTreino(dg1, codigo);

            if (TreinoController.verificaTreino >= 1)
            {
                this.Hide();
            }
            else
            {
                this.Text += frmConsultarTreino.nomeUsuario;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAlterarExercicioTreino frm = new frmAlterarExercicioTreino();
                frm.MdiParent = this.ParentForm;

                t.preencherComboBox(frm.cbExercicios);

                t.id_treino = int.Parse(dg1.CurrentRow.Cells[(Convert.ToString("id_treino"))].Value.ToString());
                t.id_usuario = int.Parse(dg1.CurrentRow.Cells[(Convert.ToString("id_user"))].Value.ToString());
                t.nome_instrutor = dg1.CurrentRow.Cells[(Convert.ToString("nome_instrutor"))].Value.ToString();
                t.nome_exercicio = dg1.CurrentRow.Cells[(Convert.ToString("nome_exercicio"))].Value.ToString();
                t.nome_aparelho = dg1.CurrentRow.Cells[(Convert.ToString("nome_aparelho"))].Value.ToString();
                t.tipo_exercicio = dg1.CurrentRow.Cells[(Convert.ToString("tipo_exercicio"))].Value.ToString();

                try
                {
                    t.series = int.Parse(dg1.CurrentRow.Cells[(Convert.ToString("series_exercicio"))].Value.ToString());
                    t.repeticoes = int.Parse(dg1.CurrentRow.Cells[(Convert.ToString("repeticoes_exercicio"))].Value.ToString());
                }
                catch { }

                try
                {
                    t.duracao = int.Parse(dg1.CurrentRow.Cells[(Convert.ToString("duracao_exercicio"))].Value.ToString());
                }
                catch { }

                DialogResult selecao = MessageBox.Show("Tem certeza que deseja alterar o exercício selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    this.Close();

                    frm.Show();

                    frm.txtCodigoTreino.Text = Convert.ToString(t.id_treino);
                    frm.txtNomeInstrutor.Text = Convert.ToString(t.nome_instrutor);

                    frm.cbExercicios.Text = Convert.ToString(t.nome_exercicio);
                    frm.txtNomeAparelho.Text = Convert.ToString(t.nome_aparelho);
                    frm.txtTipoEx.Text = Convert.ToString(t.tipo_exercicio);

                    if (t.tipo_exercicio == "Aerobico")
                    {
                        frm.txtSeries.Text = Convert.ToString(t.duracao);

                        frm.lblSeries.Text = "Tempo de Duração (minutos):";

                        frm.lblRepeticoes.Visible = false;
                        frm.txtRepeticoes.Visible = false;
                    }
                    else if (t.tipo_exercicio == "Anaerobico")
                    {
                        frm.txtRepeticoes.Text = Convert.ToString(t.repeticoes);
                        frm.txtSeries.Text = Convert.ToString(t.series);

                        frm.lblSeries.Text = "Séries:";

                        frm.lblRepeticoes.Visible = true;
                        frm.txtRepeticoes.Visible = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nenhum exercício selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoTreino = int.Parse(dg1.CurrentRow.Cells[("id_treino")].Value.ToString());
                DialogResult selecao = MessageBox.Show("Tem certeza que deseja excluir o exercício selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    t.excluirExercicio(codigoTreino);

                    codigo = frmConsultarTreino.codigoUsuario;
                    t.consultarTreino(dg1,codigo);
                }

            }
            catch
            {
                MessageBox.Show("Nenhum exercício selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
