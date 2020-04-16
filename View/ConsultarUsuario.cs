using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using SmartPersonal.View;
using System.Runtime.InteropServices;
using SmartPersonal.Controller;

namespace SmartPersonal
{
    public partial class frmConsultarUsuario : Form
    {
        UsuarioController u = new UsuarioController();
        Conexao c = new Conexao();

        public frmConsultarUsuario()
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
                        u.tipoUsuario = 2;
                        u.consultarUsuarios(dg1, tipo, keyword, u.tipoUsuario);
                    }

                    if (rdbtnEmail.Checked == true)
                    {
                        string keyword = (txtKeyWord.Text) + "%";
                        string tipo = "email_usuario";

                        u.tipoUsuario = 2;
                        u.consultarUsuarios(dg1, tipo, keyword, u.tipoUsuario);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao procurar usuário! \n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                u.codigo = int.Parse(dg1.CurrentRow.Cells[("id_usuario")].Value.ToString());
                u.nome = dg1.CurrentRow.Cells[(Convert.ToString("nome_usuario"))].Value.ToString();
                u.datanasc = dg1.CurrentRow.Cells[(Convert.ToString("datanasc_usuario"))].Value.ToString();
                u.peso = double.Parse(dg1.CurrentRow.Cells[("peso_usuario")].Value.ToString());
                u.altura = double.Parse(dg1.CurrentRow.Cells[("altura_usuario")].Value.ToString());
                u.sexo = dg1.CurrentRow.Cells[(Convert.ToString("sexo_usuario"))].Value.ToString();
                u.email = dg1.CurrentRow.Cells[(Convert.ToString("email_usuario"))].Value.ToString();
                u.login = dg1.CurrentRow.Cells[(Convert.ToString("login_usuario"))].Value.ToString();

                DialogResult selecao = MessageBox.Show("Tem certeza que deseja alterar os dados do cadastro selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selecao == DialogResult.Yes)
                {
                    frmAlterarCliente frm = new frmAlterarCliente();
                    frm.MdiParent = this.ParentForm;
                    this.Close();

                    frm.Show();

                    frm.txtCodigo.Text = Convert.ToString(u.codigo);
                    frm.txtNome.Text = u.nome;
                    frm.txtDataNasc.Text = u.datanasc;
                    frm.txtPeso.Text = Convert.ToString(u.peso);
                    frm.txtAltura.Text = Convert.ToString(u.altura);
                    frm.cbSexo.Text = u.sexo;
                    frm.txtEmail.Text = u.email;
                    frm.txtLogin.Text = u.login;
                }
            }
            catch
            {
                MessageBox.Show("Nenhum cadastro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                        u.tipoUsuario = 2;
                        u.consultarUsuarios(dg1, tipo, keyword, u.tipoUsuario);
                    }

                    if (rdbtnEmail.Checked == true)
                    {
                        string keyword = (txtKeyWord.Text) + "%";
                        string tipo = "email_usuario";

                        u.tipoUsuario = 2;
                        u.consultarUsuarios(dg1, tipo, keyword, u.tipoUsuario);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nenhum cadastro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmConsultarUsuario_Load(object sender, EventArgs e)
        {
            dg1.DefaultCellStyle.Font = new Font("Arial",9);
            dg1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
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
