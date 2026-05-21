using Dapper;
using GerenciadorReceitas.Models;
using ProjetoReceitasC_;
using ProjetoReceitasC_.Interfaces;

namespace GerenciadorReceitas.Repositories
{
    public class RepositorioIngrediente : IRepositorio<Ingrediente>
    {
        public void Inserir(Ingrediente ingrediente)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = "INSERT INTO Ingredientes (Nome, UnidadeMedida) VALUES (@Nome, @UnidadeMedida)";

            conexao.Execute(sql, ingrediente);
        }

        public void Editar(Ingrediente ingrediente)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = "UPDATE Ingredientes SET Nome = @Nome, UnidadeMedida = @UnidadeMedida WHERE Id = @Id";

            conexao.Execute(sql, ingrediente);
        }

        public void Deletar(int id)
        {
            using var conexao = Conexao.ObterConexao();
            conexao.Execute("DELETE FROM Ingredientes WHERE Id = @Id", new { Id = id });
        }

        public List<Ingrediente> Listar()
        {
            using var conexao = Conexao.ObterConexao();
            return conexao.Query<Ingrediente>("SELECT * FROM Ingredientes ORDER BY Nome").ToList();
        }

        public Ingrediente BuscarPorId(int id)
        {
            using var conexao = Conexao.ObterConexao();
            return conexao.QueryFirstOrDefault<Ingrediente>(
                "SELECT * FROM Ingredientes WHERE Id = @Id", new { Id = id });
        }
    }
}