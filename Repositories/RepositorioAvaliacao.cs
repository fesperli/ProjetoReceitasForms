using Dapper;
using GerenciadorReceitas.Models;
using ProjetoReceitasC_;
using ProjetoReceitasC_.Interfaces;

namespace GerenciadorReceitas.Repositories
{
    public class RepositorioAvaliacao : IRepositorio<Avaliacao>
    {
        public void Inserir(Avaliacao avaliacao)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = @"
                INSERT INTO Avaliacoes 
                (ReceitaId, UsuarioId, Nota, Comentario)
                VALUES 
                (@ReceitaId, @UsuarioId, @Nota, @Comentario)";

            conexao.Execute(sql, avaliacao);
        }

        public void Editar(Avaliacao avaliacao)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = @"
                UPDATE Avaliacoes
                SET ReceitaId = @ReceitaId,
                    UsuarioId = @UsuarioId,
                    Nota = @Nota,
                    Comentario = @Comentario
                WHERE Id = @Id";

            conexao.Execute(sql, avaliacao);
        }

        public void Deletar(int id)
        {
            using var conexao = Conexao.ObterConexao();
            conexao.Execute("DELETE FROM Avaliacoes WHERE Id = @Id", new { Id = id });
        }

        public List<Avaliacao> Listar()
        {
            using var conexao = Conexao.ObterConexao();

            string sql = @"
                SELECT 
                    a.Id,
                    a.ReceitaId,
                    a.UsuarioId,
                    a.Nota,
                    a.Comentario,
                    r.Nome AS ReceitaNome,
                    u.Nome AS UsuarioNome
                FROM Avaliacoes a
                INNER JOIN Receitas r ON a.ReceitaId = r.Id
                INNER JOIN Usuarios u ON a.UsuarioId = u.Id
                ORDER BY a.Id DESC";

            return conexao.Query<Avaliacao>(sql).ToList();
        }

        public Avaliacao BuscarPorId(int id)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = @"
                SELECT 
                    a.Id,
                    a.ReceitaId,
                    a.UsuarioId,
                    a.Nota,
                    a.Comentario,
                    r.Nome AS ReceitaNome,
                    u.Nome AS UsuarioNome
                FROM Avaliacoes a
                INNER JOIN Receitas r ON a.ReceitaId = r.Id
                INNER JOIN Usuarios u ON a.UsuarioId = u.Id
                WHERE a.Id = @Id";

            return conexao.QueryFirstOrDefault<Avaliacao>(sql, new { Id = id });
        }
    }
}