using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartPersonal.Controller;
using MySql.Data.MySqlClient;
using System.IO;

namespace SmartPersonal.View
{
    public partial class frmCadastroAparelho : Form
    {
        AparelhoController a = new AparelhoController();
        Conexao c = new Conexao();

        public static string foto = "";

        public frmCadastroAparelho()
        {
            InitializeComponent();
        }

        private void btnCadastrarAparelho_Click(object sender, EventArgs e)
        {
            try
            {
                a.nome = txtNome.Text;

                string q = "select nome_aparelho from tcc.aparelhos where nome_aparelho='" + a.nome + "'";
                c.abrirConexao();

                MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

                MySqlDataReader reader = puxarDados.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Esse aparelho já está cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reader.Close();
                    c.fecharConexao();
                }
                else
                {
                    a.nome = txtNome.Text;

                    if (a.nome == "")
                    {
                        MessageBox.Show("Nenhum campo pode ficar em branco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        reader.Close();
                        c.fecharConexao();
                    }
                    else if (a.foto == "")
                    {
                        MessageBox.Show("Carregue uma foto para o aparelho!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        reader.Close();
                        c.fecharConexao();
                    }
                    else
                    {
                        string caminho = a.foto.Replace(@"\\", @"/");

                        String absolutePath = caminho;
                        a.fotophp = absolutePath.Substring(20);

                        a.cadastrarAparelho();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o aparelho! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            ofdFoto.ShowDialog();
        }

        private void ofdFoto_FileOk(object sender, CancelEventArgs e)
        {
            foto = ofdFoto.FileName;
            pbFoto.Load(foto);

            a.foto = Regex.Replace(foto, @"\\", @"\\");
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

