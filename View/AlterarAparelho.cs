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
    public partial class frmAlterarAparelho : Form
    {

        int verificaFoto = 0;

        AparelhoController a = new AparelhoController();

        public frmAlterarAparelho()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult selecao = MessageBox.Show("Tem certeza que deseja cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (selecao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            pbFoto.Image = null;
            a.foto = "";
            frmConsultarAparelho.foto = "";
        }


        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar)) || (char.IsDigit(e.KeyChar)));
        }

        private void btnNovaImagem_Click(object sender, EventArgs e)
        {
            ofdFoto.ShowDialog();
        }

        private void ofdFoto_FileOk(object sender, CancelEventArgs e)
        {
            string foto;
            foto = ofdFoto.FileName;
            pbFoto.Load(foto);

            verificaFoto += 1;

            a.foto = Regex.Replace(foto, @"\\", @"\\");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                a.id_aparelho = Convert.ToInt32(txtCodigo.Text);
                a.nome = txtNome.Text;

                if (verificaFoto == 0)
                {
                    a.foto = Regex.Replace(frmConsultarAparelho.foto, @"\\", @"\\");
                }

                if (a.nome == "")
                {
                    MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (a.foto == "")
                {
                    MessageBox.Show("Carregue uma foto para o aparelho!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string caminho = a.foto.Replace(@"\\", @"/");

                    String absolutePath = caminho;
                    a.fotophp = absolutePath.Substring(20);

                    a.alterarAparelho(a.id_aparelho);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o aparelho! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
