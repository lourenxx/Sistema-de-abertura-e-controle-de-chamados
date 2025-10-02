using System.Data.SqlClient;

namespace SistemaChamados.DAO
{
    public class ConexaoDB
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST,1433; Initial Catalog=Sistema_Chamados; user id=sa; password=123456";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;

        }
    }
}
