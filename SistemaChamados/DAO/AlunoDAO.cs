using Microsoft.Data.SqlClient;
using SistemaChamados.Models;

namespace SistemaChamados.DAO
{
    public class AlunoDAO
    {
        private SqlParameter[] CriaParametros(UsuarioViewModel usuario)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("id", usuario.Id);
            parametros[1] = new SqlParameter("nome", usuario.Nome);
            return parametros;
        }
        /// <summary>
        /// Método para inserir um aluno no BD
        /// </summary>
        /// <param name="aluno">objeto aluno com todas os atributos preenchidos</param>
        public void Inserir(UsuarioViewModel usuario)
        {
            string sql =
            "insert into usuarios(id, nome)" +
            "values ( @id, @nome)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(usuario));
        }
        /// <summary>
        /// Altera um aluno no banco de dados
        /// </summary>
        /// <param name="aluno">objeto aluno com todas os atributos preenchidos</param>
        public void Alterar(UsuarioViewModel usuario)
        {
            string sql =
            "update usuarios set nome=@nome where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(usuario));
        }
        /// <summary>
        /// Exclui um aluno no banco de dados.
        /// </summary>
        /// <param name="id">id do aluno</param>
        public void Excluir(int id)
        {
            string sql = "delete usuarios where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }
    }
}
