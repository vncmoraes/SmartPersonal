using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace SmartPersonal.Controller
{
    class AparelhoController:Aparelho
    {
        Conexao c = new Conexao();

        public static int verificaAparelho=0;

        public void cadastrarAparelho()
        {
            string q = "insert into tcc.aparelhos (nome_aparelho, foto_aparelho,fotophp_aparelho) values ('" + nome + "','" + foto.ToString(new CultureInfo("pt-BR")) + "','"+fotophp+"')";
            c.executarTarefa(q);
        }

        public void puxarDadosAparelho(int codigo)
        {
            string q = " SELECT * FROM tcc.aparelhos where id_aparelho=" + codigo;
            c.abrirConexao();

            MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = puxarDados.ExecuteReader();

            while (reader.Read())
            {
                id_aparelho = reader.GetInt32("id_aparelho");
                nome = reader.GetString("nome_aparelho");
                foto = reader.GetString("foto_aparelho");
            }
            reader.Close();
            c.fecharConexao();
        }

        public void consultarAparelhos(DataGridView dadosAparelho)
        {
            string q = " SELECT * FROM tcc.aparelhos";
            c.abrirConexao();

            MySqlCommand listarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = listarDados.ExecuteReader();

            int i = 0;

            dadosAparelho.Rows.Clear();
            dadosAparelho.Refresh();

            while (reader.Read())
            {      
                dadosAparelho.Rows.Add();

                dadosAparelho.Rows[i].Cells["id_aparelho"].Value = Convert.ToInt32(reader["id_aparelho"]);
                dadosAparelho.Rows[i].Cells["nome_aparelho"].Value = Convert.ToString(reader["nome_aparelho"]);

                try
                {
                    dadosAparelho.Rows[i].Cells["foto_aparelho"].Value = Image.FromFile(Convert.ToString(reader["foto_aparelho"]));
                }
                catch
                {
                    dadosAparelho.Rows[i].Cells["foto_aparelho"].Value = null;
                }

                i++;

            }

            int count = dadosAparelho.Rows.Count;

            if (count == 0)
            {
                MessageBox.Show("Nenhum aparelho cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                verificaAparelho += 1;
            }

            reader.Close();
            c.fecharConexao();
        }

        public void alterarAparelho(int codigo)
        {
            string q = "update tcc.aparelhos set nome_aparelho='" + nome + "',foto_aparelho='"+foto+ "',fotophp_aparelho='" + fotophp + "' where id_aparelho=" + codigo;
            c.executarTarefa(q);
        }

        public void excluirAparelho(int codigo)
        {
            c.fecharConexao();
            string q = "delete from tcc.aparelhos where id_aparelho = " + codigo;
            c.executarTarefa(q);
        }
    }
}
