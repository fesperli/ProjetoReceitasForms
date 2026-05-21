using Dapper;
using GerenciadorReceitas.Models;
using ProjetoReceitasC_;
using ProjetoReceitasC_.Interfaces;

namespace GerenciadorReceitas.Repositories
{
    public class RepositorioReceita : IRepositorio<Receita>
    {
        public void Inserir(Receita receita)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = @"
                INSERT INTO Receitas 
                (Nome, ModoPreparo, TempoPreparo, CategoriaId, UsuarioId)
                VALUES 
                (@Nome, @ModoPreparo, @TempoPreparo, @CategoriaId, @UsuarioId)";

            conexao.Execute(sql, receita);
        }

        public void Editar(Receita receita)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = @"
                UPDATE Receitas
                SET Nome = @Nome,
                    ModoPreparo = @ModoPreparo,
                    TempoPreparo = @TempoPreparo,
                    CategoriaId = @CategoriaId,
                    UsuarioId = @UsuarioId
                WHERE Id = @Id";

            conexao.Execute(sql, receita);
        }

        public void Deletar(int id)
        {
            using var conexao = Conexao.ObterConexao();

            conexao.Execute("DELETE FROM Avaliacoes WHERE ReceitaId = @Id", new { Id = id });
            conexao.Execute("DELETE FROM ReceitaIngredientes WHERE ReceitaId = @Id", new { Id = id });
            conexao.Execute("DELETE FROM Receitas WHERE Id = @Id", new { Id = id });
        }

        public List<Receita> Listar()
        {
            using var conexao = Conexao.ObterConexao();

            string sql = @"
                SELECT 
                    r.Id,
                    r.Nome,
                    r.ModoPreparo,
                    r.TempoPreparo,
                    r.CategoriaId,
                    r.UsuarioId,
                    c.Nome AS CategoriaNome,
                    u.Nome AS UsuarioNome
                FROM Receitas r
                INNER JOIN Categorias c ON r.CategoriaId = c.Id
                INNER JOIN Usuarios u ON r.UsuarioId = u.Id
                ORDER BY r.Nome";

            return conexao.Query<Receita>(sql).ToList();
        }

        public Receita BuscarPorId(int id)
        {
            using var conexao = Conexao.ObterConexao();

            string sql = @"
                SELECT 
                    r.Id,
                    r.Nome,
                    r.ModoPreparo,
                    r.TempoPreparo,
                    r.CategoriaId,
                    r.UsuarioId,
                    c.Nome AS CategoriaNome,
                    u.Nome AS UsuarioNome
                FROM Receitas r
                INNER JOIN Categorias c ON r.CategoriaId = c.Id
                INNER JOIN Usuarios u ON r.UsuarioId = u.Id
                WHERE r.Id = @Id";

            return conexao.QueryFirstOrDefault<Receita>(sql, new { Id = id });
        }
    }
}