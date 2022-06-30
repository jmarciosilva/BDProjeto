using System;
using System.Data.SqlClient;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            var bd = new bd();
            var usuarioAplicacao = new UsuarioAplicacao();

          

            SqlConnection conexao = new SqlConnection(@"data source=DESKTOP-95D2SVB\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=ExemploBD");
            conexao.Open();

            //string strQueryUpdate = "UPDATE usuarios SET nome = 'Marcio' WHERE usuarioId = 1";
            //SqlCommand cmdComandoUpdate = new SqlCommand(strQueryUpdate, conexao);
            //cmdComandoUpdate.ExecuteNonQuery();

            //string strQueryDelete = "DELETE FROM usuarios WHERE usuarioId = 6";
            //SqlCommand cmdComandoDelete = new SqlCommand(strQueryDelete, conexao);
            //cmdComandoDelete.ExecuteNonQuery();

            Console.Write("Digite o Nome do Usuário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Cargo do Usuario: ");
            string cargo = Console.ReadLine();

            Console.Write("Digite a Data de Cadastro: ");
            string data = Console.ReadLine();

            // string strQueryInsert = string.Format("INSERT INTO usuarios (nome, cargo, data) VALUES ('{0}', '{1}', '{2}')", nome, cargo, data);
            // bd.ExecutaComando(strQueryInsert);

            usuarioAplicacao.insert(nome, cargo, data);

            string strQuerySelect = "SELECT * FROM usuarios";
            SqlDataReader dados = bd.ExecutaComandoComRetorno(strQuerySelect);
            
            //string strQueryInsert = string.Format("INSERT INTO usuarios (nome, cargo, data) VALUES ('{0}', '{1}', '{2}')", nome, cargo, data);
            //SqlCommand cmdComandoInsert = new SqlCommand(strQueryInsert, conexao);
            //cmdComandoInsert.ExecuteNonQuery();

            //string strQuerySelect = "SELECT * FROM usuarios";
            //SqlCommand cmdComandoSelect = new SqlCommand(strQuerySelect, conexao);
            //SqlDataReader dados = cmdComandoSelect.ExecuteReader();

            while (dados.Read())
            {
                Console.WriteLine("ID: {0}, Nome: {1}, Cargo: {2}, Data: {3}", dados["usuarioId"], dados["nome"], dados["cargo"], dados["data"]);
            }


        }
    }
}
