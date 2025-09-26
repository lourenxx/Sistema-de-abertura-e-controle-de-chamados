using Microsoft.Data.SqlClient;

namespace SistemaChamados.DAO
{
    public class ConexaoDB
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST; Database=Sistema_Chamados; user id=sa; password=123456";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;

        }
    }
}
