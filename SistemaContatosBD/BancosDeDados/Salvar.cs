using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaContatosBD.Dados;

namespace SistemaContatosBD.BancosDeDados
{
    public class Salvar
    {
        public static string SalvarContato(Contato Contatos)
        {
            string connectionString = "Server=127.17.0.2;Uid=sistema;Pwd=sistema;Database=LPA2;";
            string command = "INSERT INTO TB_CONTATOS VALUES (NULL, @Nome, @Telefone, @Celular, @Email, @Tipo)";

            try
            {
                MySqlConnection conn = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand();
                conn.ConnectionString = connectionString;
                cmd.CommandText = command;
                conn.Open();
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@Nome", Contatos.Nome);
                cmd.Parameters.AddWithValue("@Telefone", Contatos.Telefone);
                cmd.Parameters.AddWithValue("@Celular", Contatos.Celular);
                cmd.Parameters.AddWithValue("@Email", Contatos.Email);
                cmd.Parameters.AddWithValue("@Tipo", Contatos.Tipo);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                conn.Close();

                return "Succeso";
            }
            catch (Exception ex)
            {
                return $"Ocorreu um Erro {ex.Message}";
            }
        }
    }
}
