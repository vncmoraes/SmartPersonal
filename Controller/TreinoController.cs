using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SmartPersonal.View;

namespace SmartPersonal.Controller
{
    class TreinoController : Treino
    {
        public string tipoExercicio="";
        public static int verificaTreino = 0;

        Conexao c = new Conexao();

        public void cadastrarExercicioTreino()
        {
            if (tipo_exercicio == "Anaerobico")
            {
                string q = "insert into tcc.treino (id_usuario, nome_instrutor, nome_exercicio, nome_aparelho, tipo_exercicio, series_exercicio, repeticoes_exercicio) values ('" + id_usuario + "','" + nome_instrutor + "','" + nome_exercicio + "','" + nome_aparelho + "','" + tipo_exercicio + "','" + series + "','" + repeticoes + "')";
                c.executarTarefa(q);
            }
            else if (tipo_exercicio == "Aerobico")
            {
                string q = "insert into tcc.treino (id_usuario, nome_instrutor, nome_exercicio, nome_aparelho, tipo_exercicio, duracao_exercicio) values ('" + id_usuario + "','" + nome_instrutor + "','" + nome_exercicio + "','" + nome_aparelho + "','" + tipo_exercicio + "','" + duracao + "')";
                c.executarTarefa(q);
            }
        }

        public void puxarDadosTreino(int codigo)
        {
            string q = " SELECT * FROM tcc.treino where id_treino=" + codigo;
            c.abrirConexao();

            MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = puxarDados.ExecuteReader();

            while (reader.Read())
            {
                id_treino = reader.GetInt32("id_treino");
                id_usuario = reader.GetInt32("id_usuario");
                nome_instrutor = reader.GetString("nome_instrutor");
                nome_exercicio = reader.GetString("nome_exercicio");
                nome_aparelho = reader.GetString("nome_aparelho");
                series = reader.GetInt32("series_exercicio");
                repeticoes = reader.GetInt32("repeticoes_exercicio");
            }
            reader.Close();
            c.fecharConexao();
        }


        public void consultarCliente(DataGridView dadosUsuario, string tipoPesquisa, string keyword)
        {
            string q = " SELECT id_usuario,nome_usuario,email_usuario,login_usuario FROM tcc.usuarios where (" + tipoPesquisa + " like '" + keyword + "') and (tipo_usuario=2)";
            c.abrirConexao();

            MySqlCommand listarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = listarDados.ExecuteReader();

            int i = 0;

            dadosUsuario.Rows.Clear();
            dadosUsuario.Refresh();

            while (reader.Read())
            {
                dadosUsuario.Rows.Add();
                dadosUsuario.Rows[i].Cells["id_usuario"].Value = Convert.ToInt32(reader["id_usuario"]);
                dadosUsuario.Rows[i].Cells["nome_usuario"].Value = Convert.ToString(reader["nome_usuario"]);
                dadosUsuario.Rows[i].Cells["email_usuario"].Value = Convert.ToString(reader["email_usuario"]);
                dadosUsuario.Rows[i].Cells["login_usuario"].Value = Convert.ToString(reader["login_usuario"]);
                i++;

            }

            int linhas = dadosUsuario.Rows.Count;

            if (linhas == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            reader.Close();
            c.fecharConexao();
        }

        public void consultarTreino(DataGridView dadosTreino, int codigo)
        {
            try
            {
                string q = " SELECT * FROM tcc.treino where id_usuario='" + codigo + "'"; ;
                c.abrirConexao();

                MySqlCommand listarDados = new MySqlCommand(q, c.mcon);

                MySqlDataReader reader = listarDados.ExecuteReader();

                int i = 0;

                dadosTreino.Rows.Clear();
                dadosTreino.Refresh();

                while (reader.Read())
                {
                    dadosTreino.Rows.Add();

                    tipoExercicio = Convert.ToString(reader["tipo_exercicio"]);

                    dadosTreino.Rows[i].Cells["id_treino"].Value = Convert.ToInt32(reader["id_treino"]);
                    dadosTreino.Rows[i].Cells["id_user"].Value = Convert.ToInt32(reader["id_usuario"]);
                    dadosTreino.Rows[i].Cells["nome_instrutor"].Value = Convert.ToString(reader["nome_instrutor"]);
                    dadosTreino.Rows[i].Cells["nome_exercicio"].Value = Convert.ToString(reader["nome_exercicio"]);
                    dadosTreino.Rows[i].Cells["nome_aparelho"].Value = Convert.ToString(reader["nome_aparelho"]);
                    dadosTreino.Rows[i].Cells["tipo_exercicio"].Value = tipoExercicio;

                    if (tipoExercicio == "Aerobico")
                    {
                        dadosTreino.Rows[i].Cells["duracao_exercicio"].Value = Convert.ToInt32(reader["duracao_exercicio"]);

                        dadosTreino.Rows[i].Cells["series_exercicio"].Value = "-";
                        dadosTreino.Rows[i].Cells["repeticoes_exercicio"].Value = "-";
                    }
                    else if (tipoExercicio == "Anaerobico")
                    {
                        dadosTreino.Rows[i].Cells["series_exercicio"].Value = Convert.ToInt32(reader["series_exercicio"]);
                        dadosTreino.Rows[i].Cells["repeticoes_exercicio"].Value = Convert.ToInt32(reader["repeticoes_exercicio"]);

                        dadosTreino.Rows[i].Cells["duracao_exercicio"].Value = "-";
                    }

                    i++;

                }

                int linhas = dadosTreino.Rows.Count;

                if (linhas == 0)
                {
                    MessageBox.Show("Nenhum exercício cadastrado para o usuário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    verificaTreino += 1;
                }

                reader.Close();
                c.fecharConexao();
            }
            catch { }
        }

        public void preencherComboBox(ComboBox exercicios)
        {
            string q = " SELECT nome_exercicio FROM tcc.exercicios";
            c.abrirConexao();

            MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = puxarDados.ExecuteReader();

            while (reader.Read())
            {
                nome_exercicio = reader.GetString("nome_exercicio");
                exercicios.Items.Add(nome_exercicio);

            }
            reader.Close();
            c.fecharConexao();
        }

        public void puxarDadosExercicio(string exercicio)
        {
            string q = " SELECT nome_aparelho,tipo_exercicio FROM tcc.exercicios where nome_exercicio='" + exercicio + "'";
            c.abrirConexao();

            MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = puxarDados.ExecuteReader();

            while (reader.Read())
            {
                nome_aparelho = reader.GetString("nome_aparelho");
                tipo_exercicio = reader.GetString("tipo_exercicio");
            }
            reader.Close();
            c.fecharConexao();
        }

        public void alterarExercicio(int codigo)
        {
            string q = "update tcc.treino set nome_instrutor='" + nome_instrutor + "',nome_exercicio='" + nome_exercicio + "',nome_aparelho='" + nome_aparelho + "',series_exercicio='" + series + "',repeticoes_exercicio='" + repeticoes + "',duracao_exercicio='" + duracao + "' where id_treino=" + codigo;
            c.executarTarefa(q);
        }

        public void excluirExercicio(int codigo)
        {
            string q = "delete from tcc.treino where id_treino = " + codigo;
            c.executarTarefa(q);
        }
    }
}
