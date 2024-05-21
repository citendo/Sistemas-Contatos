using MySql.Data.MySqlClient;
using SistemaContatosBD.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContatosBD.BancosDeDados
{
    public class Carregar
    {
        public static List<Contato> CarregarContatos()
        {
            string connectionString = "Server=127.17.0.2;Uid=sistema;Pwd=sistema;Database=LPA2;";
            string command = "Select Nome,Telefone,Celular,Email,Tipo from TB_CONTATOS";

            List<Contato> ListaContatos = new List<Contato>();

            try
            {
                MySqlConnection conn = new MySqlConnection();
                MySqlCommand cmd = new MySqlCommand();
                conn.ConnectionString = connectionString;
                cmd.CommandText = command;
                conn.Open();
                cmd.Connection = conn;
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string nome = dr[0].ToString();
                    string telefone = dr[1].ToString();
                    string celular = dr[2].ToString();
                    string email = dr[3].ToString();
                    string tipo = dr[4].ToString();

                    Contato contatos = new Contato(nome, telefone, celular, email, tipo);

                    ListaContatos.Add(contatos);
                }


                return ListaContatos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
