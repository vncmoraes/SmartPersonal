using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace SmartPersonal.Controller
{
    class UsuarioController:Usuario
    {
        Conexao c = new Conexao();

        public void cadastrarUsuario(int tipoUsuario)
        {
            if (tipoUsuario == 2)
            {
                string q = "insert into tcc.usuarios (nome_usuario,datanasc_usuario,peso_usuario,altura_usuario,sexo_usuario,email_usuario,login_usuario,senha_usuario,tipo_usuario,ativo_usuario,passreset_usuario) values('" + nome + "','" + datanasc + "','" + peso.ToString("N", new CultureInfo("en-US")) + "','" + altura.ToString("N", new CultureInfo("en-US")) + "','" + sexo + "','" + email + "','" + login + "','" + senhacrip + "','" + tipoUsuario + "','" + status + "','" + reset + "')";
                c.executarTarefa(q);

            }
            else if (tipoUsuario == 1)
            {
                string q = "insert into tcc.usuarios (nome_usuario,login_usuario,senha_usuario,tipo_usuario,ativo_usuario,passreset_usuario) values('" + nome + "','" + login + "','" + senhacrip + "','" + tipoUsuario + "','" + status + "','" + reset + "')";
                c.executarTarefa(q);
            }
        }

        public void puxarDadosCliente(int codigo)
        {
            string q = " SELECT * FROM tcc.usuarios where id_usuario=" + codigo;
            c.abrirConexao();

            MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = puxarDados.ExecuteReader();

            while (reader.Read())
            {
                nome = reader.GetString("nome_usuario");
                datanasc = reader.GetString("datanasc_usuario");
                peso = reader.GetDouble("peso_usuario");
                altura = reader.GetDouble("altura_usuario");
                sexo = reader.GetString("sexo_usuario");
                email = reader.GetString("email_usuario");
                login = reader.GetString("login_usuario");
                senha = reader.GetString("senha_usuario");
                tipoUsuario = reader.GetInt32("tipo_usuario");
            }
            reader.Close();
            c.fecharConexao();

        }

        public void puxarDadosAdmin()
        {
            string q = " SELECT nome_usuario,login_usuario FROM tcc.usuarios where tipo_usuario=0";
            c.abrirConexao();

            MySqlCommand puxarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = puxarDados.ExecuteReader();

            while (reader.Read())
            {
                nome = reader.GetString("nome_usuario");
                login = reader.GetString("login_usuario");
            }

            codigo = 1;
            tipoUsuario = 2;

            reader.Close();
            c.fecharConexao();
        }


        public void consultarUsuarios(DataGridView dadosUsuario, string tipoPesquisa, string keyword, int tipoUsuario)
        {
            string q = " SELECT * FROM tcc.usuarios where (" + tipoPesquisa + " like '" + keyword + "') and (tipo_usuario=" + tipoUsuario + ")";
            c.abrirConexao();

            MySqlCommand listarDados = new MySqlCommand(q, c.mcon);

            MySqlDataReader reader = listarDados.ExecuteReader();

            int i = 0;

            dadosUsuario.Rows.Clear();
            dadosUsuario.Refresh();

            if (tipoUsuario == 2)
            {
                while (reader.Read())
                {
                    peso = Convert.ToDouble(reader["peso_usuario"]);
                    altura = Convert.ToDouble(reader["altura_usuario"]);

                    dadosUsuario.Rows.Add();
                    dadosUsuario.Rows[i].Cells["id_usuario"].Value = Convert.ToInt32(reader["id_usuario"]);
                    dadosUsuario.Rows[i].Cells["nome_usuario"].Value = Convert.ToString(reader["nome_usuario"]);
                    dadosUsuario.Rows[i].Cells["datanasc_usuario"].Value = Convert.ToString(reader["datanasc_usuario"]);
                    dadosUsuario.Rows[i].Cells["peso_usuario"].Value = peso.ToString("N", new CultureInfo("pt-BR"));
                    dadosUsuario.Rows[i].Cells["altura_usuario"].Value = altura.ToString("N", new CultureInfo("pt-BR"));
                    dadosUsuario.Rows[i].Cells["sexo_usuario"].Value = Convert.ToString(reader["sexo_usuario"]);
                    dadosUsuario.Rows[i].Cells["email_usuario"].Value = Convert.ToString(reader["email_usuario"]);
                    dadosUsuario.Rows[i].Cells["login_usuario"].Value = Convert.ToString(reader["login_usuario"]);
                    i++;


                }
            }
            else if (tipoUsuario == 1)
            {
                while (reader.Read())
                {
                    dadosUsuario.Rows.Add();
                    dadosUsuario.Rows[i].Cells["id_usuario"].Value = Convert.ToInt32(reader["id_usuario"]);
                    dadosUsuario.Rows[i].Cells["nome_usuario"].Value = Convert.ToString(reader["nome_usuario"]);
                    dadosUsuario.Rows[i].Cells["login_usuario"].Value = Convert.ToString(reader["login_usuario"]);
                    i++;
                }

            }

            int linhas = dadosUsuario.Rows.Count;

            if (linhas == 0)
            {
                MessageBox.Show("Nenhum usuário encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            reader.Close();
            c.fecharConexao();
        }


        public void alterarUsuario(int codigo, int tipoUsuario)
        {
            if (tipoUsuario == 2)
            {
                string q = "update tcc.usuarios set nome_usuario='" + nome + "',datanasc_usuario='" + datanasc + "',peso_usuario='" + peso.ToString("N", new CultureInfo("en-US")) + "',altura_usuario='" + altura.ToString("N", new CultureInfo("en-US")) + "',sexo_usuario='" + sexo + "',email_usuario='" + email + "',login_usuario='" + login + "' where id_usuario=" + codigo;
                c.executarTarefa(q);
            }
            else if (tipoUsuario == 1)
            {
                string q = "update tcc.usuarios set nome_usuario='" + nome + "', login_usuario='" + login + "' where id_usuario=" + codigo;
                c.executarTarefa(q);
            }
            else if (tipoUsuario == 0)
            {
                string q = "update tcc.usuarios set nome_usuario='" + nome + "', login_usuario='" + login + "', senha_usuario='" + senhacrip + "' where id_usuario=" + codigo;
                c.executarTarefa(q);
            }
        }

        public void excluirUsuario(int codigo)
        {
            string q = "delete from tcc.usuarios where id_usuario = " + codigo;
            c.executarTarefa(q);

        }
    }
}
