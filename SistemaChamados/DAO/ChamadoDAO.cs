using Microsoft.Data.SqlClient;
using SistemaChamados.Models;

namespace SistemaChamados.DAO
{
    public class ChamadoDAO
    {
        private SqlParameter[] CriaParametros(ChamadosViewModel chamado)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("id", chamado.Id);
            parametros[1] = new SqlParameter("dataAbertura", chamado.dataAbertura);
            parametros[2] = new SqlParameter("descricaoAtendimento", chamado.descricaoAtendimento);
            parametros[3] = new SqlParameter("dataAtendimento", chamado.dataAtendimento);
            parametros[4] = new SqlParameter("situacao", chamado.situacao);
            parametros[5] = new SqlParameter("usuarioId", chamado.usuarioId);
            return parametros;
        }
        /// <summary>
        /// Método para inserir um aluno no BD
        /// </summary>
        /// <param name="aluno">objeto aluno com todas os atributos preenchidos</param>
        public void Inserir(ChamadosViewModel chamado)
        {
            string sql =
            "insert into chamados(id, dataAbertura, descricaoAtendimento, dataAtendimento, situacao, usuarioId)" +
            "values ( @id, @dataAbertura, @descricaoAtendimento, @dataAtendimento, @situacao, @usuarioId)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(chamado));
        }
        /// <summary>
        /// Altera um aluno no banco de dados
        /// </summary>
        /// <param name="aluno">objeto aluno com todas os atributos preenchidos</param>
        public void Alterar(ChamadosViewModel chamado)
        {
            string sql =
            "update chamados set dataAbertura=@dataAbertura, descricaoAtendimento=@descricaoAtendimento, " +
            "dataAtendimento=@dataAtendimento, situacao=@situacao, usuarioId=@usuarioId where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(chamado));
        }
        /// <summary>
        /// Exclui um aluno no banco de dados.
        /// </summary>
        /// <param name="id">id do aluno</param>
        public void Excluir(int id)
        {
            string sql = "delete chamados where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

    }
}
