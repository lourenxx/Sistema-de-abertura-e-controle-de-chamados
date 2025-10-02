using Microsoft.Data.SqlClient;
using SistemaChamados.Models;
using System.Collections.Generic;
using System.Data;

namespace SistemaChamados.DAO
{
    public class UsuarioDAO
    {
        private SqlParameter[] CriaParametros(UsuarioViewModel usuario, bool isInsert = false)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            if (!isInsert)
            {
                parametros.Add(new SqlParameter("id", usuario.Id));
            }
            parametros.Add(new SqlParameter("nome", usuario.Nome));
            return parametros.ToArray();
        }

        public List<UsuarioViewModel> Listar()
        {
            List<UsuarioViewModel> lista = new List<UsuarioViewModel>();
            string sql = "select * from usuarios";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);

            foreach (DataRow registro in tabela.Rows)
                lista.Add(new UsuarioViewModel
                {
                    Id = int.Parse(registro["id"].ToString()),
                    Nome = registro["nome"].ToString()
                });

            return lista;
        }
        /// <summary>
        /// Método para inserir um usuário no BD
        /// </summary>
        /// <param name="usuario">objeto usuario com todas os atributos preenchidos</param>
        public void Inserir(UsuarioViewModel usuario)
        {
            string sql =
            "insert into usuarios(nome)" +
            "values (@nome)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(usuario, true));
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
