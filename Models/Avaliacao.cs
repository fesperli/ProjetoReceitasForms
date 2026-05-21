using ProjetoReceitasC_.Models;

namespace GerenciadorReceitas.Models
{
    public class Avaliacao : EntidadeBase
    {
        public int ReceitaId { get; set; }
        public int UsuarioId { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; }

        public string ReceitaNome { get; set; }
        public string UsuarioNome { get; set; }

        public override string ToString()
        {
            return $"{ReceitaNome} - Nota {Nota} - {UsuarioNome}";
        }
    }
}