using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SmartPersonal.View;

namespace SmartPersonal.Controller
{
    class ExercicioController:Exercicio
    {
        Conexao c = new Conexao();
        Aparelho a = new Aparelho();

        public static int verificaExercicio = 0;

        public void cadastrarExercicio()
        {
            string q = "insert into tcc.exercicios (nome_exercicio, nome_aparelho,tipo_exercicio) values ('" + nome_exercicio + "','" + nome_aparelho + "','"+tipo_exercicio+"')";
            c.executarTarefa(q);
        }

        public void puxarDadosExercicio(int codigo)
        {
            string q = " SELECT * FROM tcc.exercicios where id_exercicio=" + codigo;
            c.abrirConexao();

            MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = puxarDados.ExecuteReader();

            while (reader.Read())
            {
                id_exercicio = reader.GetInt32("id_exercicio");
                nome_exercicio = reader.GetString("nome_exercicio");
                nome_aparelho = reader.GetString("nome_aparelho");
                tipo_exercicio = reader.GetString("tipo_exercicio");
            }

            reader.Close();
            c.fecharConexao();
        }

        public void preencherComboBox(ComboBox Aparelhos)
        {
            string q = " SELECT nome_aparelho FROM tcc.aparelhos";
            c.abrirConexao();

            MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = puxarDados.ExecuteReader();

            while (reader.Read())
            {
                a.nome = reader.GetString("nome_aparelho");

                Aparelhos.Items.Add(a.nome);

            }

            frmAlterarExercicio frm = new frmAlterarExercicio();

            reader.Close();
            c.fecharConexao();
        }

        public void consultarExercicios(DataGridView dadosExercicio)
        {
            string q = " SELECT * FROM tcc.exercicios";
            c.abrirConexao();

            MySqlCommand listarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = listarDados.ExecuteReader();

            int i = 0;

            dadosExercicio.Rows.Clear();
            dadosExercicio.Refresh();

            while (reader.Read())
            {
                dadosExercicio.Rows.Add();
                dadosExercicio.Rows[i].Cells["id_exercicio"].Value = Convert.ToInt32(reader["id_exercicio"]);
                dadosExercicio.Rows[i].Cells["nome_exercicio"].Value = Convert.ToString(reader["nome_exercicio"]);
                dadosExercicio.Rows[i].Cells["nome_aparelho"].Value = Convert.ToString(reader["nome_aparelho"]);
                dadosExercicio.Rows[i].Cells["tipo_exercicio"].Value = Convert.ToString(reader["tipo_exercicio"]);
                i++;

            }

            int linhas = dadosExercicio.Rows.Count;

            if (linhas == 0)
            {
                MessageBox.Show("Nenhum exercício cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                verificaExercicio += 1;
            }

            reader.Close();
            c.fecharConexao();
        }

        public void alterarExercicio(int codigo)
        {
            string q = "update tcc.exercicios set nome_exercicio='" + nome_exercicio + "',nome_aparelho='" + nome_aparelho + "',tipo_exercicio='" + tipo_exercicio + "' where id_exercicio=" + codigo;
            c.executarTarefa(q);
        }

        public void excluirExercicio(int codigo)
        {
            string q = "delete from tcc.exercicios where id_exercicio = " + codigo;
            c.executarTarefa(q);
        }
    }
}
