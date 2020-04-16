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
    public partial class frmAlterarExercicioTreino : Form
    {
        TreinoController t = new TreinoController();

        public frmAlterarExercicioTreino()
        {
            InitializeComponent();
        }

        private void cbExercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exercicio = cbExercicios.Text;

            t.puxarDadosExercicio(exercicio);

            txtNomeAparelho.Text = t.nome_aparelho;
            txtTipoEx.Text = t.tipo_exercicio;

            if (txtTipoEx.Text == "Aerobico")
            {
                lblSeries.Text = "Tempo de Duração (minutos):";

                txtSeries.Text = "";

                lblRepeticoes.Visible = false;
                txtRepeticoes.Visible = false;
            }
            else if (txtTipoEx.Text == "Anaerobico")
            {
                lblSeries.Text = "Séries:";

                txtRepeticoes.Text = "";
                txtSeries.Text = "";

                lblRepeticoes.Visible = true;
                txtRepeticoes.Visible = true;


            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbExercicios.SelectedItem = null;

            txtNomeAparelho.Text = "";
            txtRepeticoes.Text = "";
            txtSeries.Text = "";
            txtTipoEx.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                t.id_treino = Convert.ToInt32(txtCodigoTreino.Text);
                t.nome_instrutor = txtNomeInstrutor.Text;
                t.nome_exercicio = cbExercicios.Text;
                t.nome_aparelho = txtNomeAparelho.Text;
                t.tipo_exercicio = txtTipoEx.Text;

                if (t.tipo_exercicio == "Anaerobico")
                {
                    t.duracao = 0;

                    try
                    {
                        t.series = Convert.ToInt32(txtSeries.Text);
                        t.repeticoes = Convert.ToInt32(txtRepeticoes.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                else if (t.tipo_exercicio == "Aerobico")
                {
                    t.repeticoes = 0;
                    t.series = 0;

                    try
                    {
                        t.duracao = Convert.ToInt32(txtSeries.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (t.nome_exercicio == "" || t.nome_aparelho == "" || t.tipo_exercicio == "")
                {
                    MessageBox.Show("Selecione um exercício para continuar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    t.alterarExercicio(t.id_treino);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o exercício! \n\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar)) || (char.IsPunctuation(e.KeyChar));
        }

        private void txtRepeticoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar)) || (char.IsPunctuation(e.KeyChar));
        }
    }
}
