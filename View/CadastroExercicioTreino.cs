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
using SmartPersonal.View;

namespace SmartPersonal.View
{
    public partial class frmCadastroExercicioTreino : Form
    {
        TreinoController t = new TreinoController();

        public frmCadastroExercicioTreino()
        {
            InitializeComponent();
        }

        private void frmCadastroExercicioTreino_Load(object sender, EventArgs e)
        {
            txtNomeInstrutor.Text = frmLogin.nomeInstrutor;

            t.preencherComboBox(cbExercicios);
            this.cbExercicios.SelectedIndexChanged += new System.EventHandler(cbExercicios_SelectedIndexChanged);
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

                lblRepeticoes.Visible = false;
                txtRepeticoes.Visible = false;
            }
            else if (txtTipoEx.Text == "Anaerobico")
            {
                lblSeries.Text = "Séries:";

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                t.id_usuario = Convert.ToInt32(txtCodigoUsuario.Text);
                t.nome_instrutor = txtNomeInstrutor.Text;
                t.nome_exercicio = cbExercicios.Text;
                t.nome_aparelho = txtNomeAparelho.Text;
                t.tipo_exercicio = txtTipoEx.Text;

                if (t.tipo_exercicio == "Anaerobico")
                {
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
                    t.cadastrarExercicioTreino();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar um novo exercício! \n\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar) || (char.IsPunctuation(e.KeyChar)));
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

        private void txtRepeticoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsLetter(e.KeyChar)) || (char.IsPunctuation(e.KeyChar));
        }
    }
}
