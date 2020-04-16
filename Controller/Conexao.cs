using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartPersonal
{
    class Conexao
    {
        public MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand mcd;

        public void abrirConexao()
        {
            try
            {
                mcon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados" +
                    "\nDescrição do erro: \n" + ex.Message, "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        }

        public void fecharConexao()
        {
            try
            {
                mcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados" +
                    "\nDescrição do erro: \n" + ex.Message, "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        }

        public void executarTarefa(string q)
        {
            try
            {
                abrirConexao();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Tarefa efetuada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tarefa não efetuada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
