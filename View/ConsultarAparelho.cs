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
using System.Text.RegularExpressions;

namespace SmartPersonal.View
{
    public partial class frmConsultarAparelho : Form
    {
        public static string foto = "";

        AparelhoController a = new AparelhoController();

        public frmConsultarAparelho()
        {
            InitializeComponent();
        }

        private void ConsultarAparelho_Load(object sender, EventArgs e)
        {
            AparelhoController.verificaAparelho = 0;

            dg1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            a.consultarAparelhos(dg1);

            if (AparelhoController.verificaAparelho >= 1)
            {
                this.Hide();
            }
            else
            {
                dg1.Columns["nome_aparelho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg1.Columns["nome_aparelho"].DefaultCellStyle.Font = new Font("Arial", 12);
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
                int codigo = int.Parse(dg1.CurrentRow.Cells[("id_aparelho")].Value.ToString());
                DialogResult selecao = MessageBox.Show("Tem certeza que deseja excluir o cadastro selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    a.excluirAparelho(codigo);
                    a.consultarAparelhos(dg1);
                }
            }
            catch
            {
                MessageBox.Show("Nenhum aparelho selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                a.id_aparelho = int.Parse(dg1.CurrentRow.Cells[("id_aparelho")].Value.ToString());

                a.puxarDadosAparelho(a.id_aparelho);

                a.nome = dg1.CurrentRow.Cells[(Convert.ToString("nome_aparelho"))].Value.ToString();

                DialogResult selecao = MessageBox.Show("Tem certeza que deseja alterar os dados do cadastro selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    frmAlterarAparelho frm = new frmAlterarAparelho();
                    frm.MdiParent = this.ParentForm;
                    this.Close();

                    frm.Show();

                    frm.txtCodigo.Text = Convert.ToString(a.id_aparelho);
                    frm.txtNome.Text = a.nome;

                    foto = a.foto;

                    frm.pbFoto.Load(a.foto);

                }
            }
            catch
            {
                MessageBox.Show("Nenhum aparelho selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
