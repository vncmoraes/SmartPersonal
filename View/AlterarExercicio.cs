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
    public partial class frmAlterarExercicio : Form
    {
        ExercicioController ex = new ExercicioController();

        public frmAlterarExercicio()
        {
            InitializeComponent();
        }

        private void frmAlterarExercicio_Load(object sender, EventArgs e)
        {
            ex.preencherComboBox(cbAparelho);

            cbAparelho.Text = Convert.ToString(frmConsultarExercicio.nomeAparelho);
            cbTipoEx.Text = Convert.ToString(frmConsultarExercicio.tipoExercicio);  
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ex.id_exercicio = Convert.ToInt32(txtCodigo.Text);
                ex.nome_exercicio = txtNomeEx.Text;
                ex.nome_aparelho = cbAparelho.Text;
                ex.tipo_exercicio = cbTipoEx.Text;

                if (ex.nome_exercicio == "" || ex.nome_aparelho == "" || ex.tipo_exercicio == "")
                {
                    MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    ex.alterarExercicio(ex.id_exercicio);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o exercício! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeEx.Text = "";

            cbAparelho.Text = null;
            cbTipoEx.Text = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNomeEx_KeyPress(object sender, KeyPressEventArgs e)
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
