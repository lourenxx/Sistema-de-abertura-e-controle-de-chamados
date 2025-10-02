using Microsoft.Data.SqlClient;
using System.Data;

namespace SistemaChamados.DAO
{
    public class HelperDAO
    {
        public static void ExecutaSQL(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    // comando.Parameters nunca deve ser nulo após a inicialização do SqlCommand
                    // No entanto, para garantir, a verificação de parametros != null é suficiente.
                    // O erro anterior pode ter sido causado por 'parametros' ser nulo quando não deveria ser.
                    if (parametros != null && parametros.Length > 0)
                        comando.Parameters.AddRange(parametros);
                    comando.ExecuteNonQuery();
                }
            }

        }

        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection conexao = ConexaoDB.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    // Garante que SelectCommand não seja nulo antes de adicionar parâmetros
                    if (adapter.SelectCommand == null)
                    {
                        adapter.SelectCommand = new SqlCommand(sql, conexao);
                    }

                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    conexao.Close();
                    return tabela;
                }
            }
        }
    }
}
