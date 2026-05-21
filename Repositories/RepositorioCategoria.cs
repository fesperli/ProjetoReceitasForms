using Dapper;
using GerenciadorReceitas.Models;
using ProjetoReceitasC_;
using ProjetoReceitasC_.Interfaces;

namespace GerenciadorReceitas.Repositories
{
    public class RepositorioCategoria : IRepositorio<Categoria>
    {
        public void Inserir(Categoria categoria)
        {
            using var conexao = Conexao.ObterConexao();
            conexao.Execute("INSERT INTO Categorias (Nome) VALUES (@Nome)", categoria);
        }

        public void Editar(Categoria categoria)
        {
            using var conexao = Conexao.ObterConexao();
            conexao.Execute("UPDATE Categorias SET Nome = @Nome WHERE Id = @Id", categoria);
        }

        public void Deletar(int id)
        {
            using var conexao = Conexao.ObterConexao();
            conexao.Execute("DELETE FROM Categorias WHERE Id = @Id", new { Id = id });
        }

        public List<Categoria> Listar()
        {
            using var conexao = Conexao.ObterConexao();
            return conexao.Query<Categoria>("SELECT * FROM Categorias ORDER BY Nome").ToList();
        }

        public Categoria BuscarPorId(int id)
        {
            using var conexao = Conexao.ObterConexao();
            return conexao.QueryFirstOrDefault<Categoria>(
                "SELECT * FROM Categorias WHERE Id = @Id", new { Id = id });
        }
    }
}