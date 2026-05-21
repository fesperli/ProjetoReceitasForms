using Dapper;
using GerenciadorReceitas.Models;
using ProjetoReceitasC_;
using ProjetoReceitasC_.Interfaces;

namespace GerenciadorReceitas.Repositories
{
    public class RepositorioUsuario : IRepositorio<Usuario>
    {
        public void Inserir(Usuario usuario)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = "INSERT INTO Usuarios (Nome, Email) VALUES (@Nome, @Email)";

            conexao.Execute(sql, usuario);
        }

        public void Editar(Usuario usuario)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = "UPDATE Usuarios SET Nome = @Nome, Email = @Email WHERE Id = @Id";

            conexao.Execute(sql, usuario);
        }

        public void Deletar(int id)
        {
            using var conexao = Conexao.ObterConexao();
            conexao.Execute("DELETE FROM Usuarios WHERE Id = @Id", new { Id = id });
        }

        public List<Usuario> Listar()
        {
            using var conexao = Conexao.ObterConexao();
            return conexao.Query<Usuario>("SELECT * FROM Usuarios ORDER BY Nome").ToList();
        }

        public Usuario BuscarPorId(int id)
        {
            using var conexao = Conexao.ObterConexao();
            return conexao.QueryFirstOrDefault<Usuario>(
                "SELECT * FROM Usuarios WHERE Id = @Id", new { Id = id });
        }
    }
}